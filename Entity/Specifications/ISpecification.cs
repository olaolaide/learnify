﻿using System.Linq.Expressions;

namespace Entity.Specifications;

public interface ISpecification<T>
{
    Expression<Func<T, bool>> Criteria { get; }
    List<Expression<Func<T, object>>> Include { get; }
    
    Expression<Func<T, object>> SortByAscending { get; }
    Expression<Func<T, object>> SortByDescending { get; }
}