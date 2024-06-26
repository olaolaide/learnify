﻿using Entity.Specifications;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Utils;

public class SpecificationEvaluator<T> where T : class
{
    public static IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> spec)
    {
        var query = inputQuery;
        if (spec.Criteria != null)
        {
            query = query.Where(spec.Criteria);
        }

        if (spec.SortByAscending != null)
        {
            query = query.OrderBy(spec.SortByAscending);
        }

        if (spec.SortByDescending != null)
        {
            query = query.OrderByDescending(spec.SortByDescending);
        }

        query = spec.Include.Aggregate(query, (current, include) => current.Include(include));
        return query;
    }
}