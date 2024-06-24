using System.Linq.Expressions;

namespace Entity.Specifications;

public class BaseSpecification<T> : ISpecification<T>
{
    public BaseSpecification()
    {
    }

    public BaseSpecification(Expression<Func<T, bool>> criteria)
    {
        Criteria = criteria;
    }

    public Expression<Func<T, bool>> Criteria { get; }
    public List<Expression<Func<T, object>>> Include { get; } = [];
    public Expression<Func<T, object>> SortByAscending { get; private set; }
    public Expression<Func<T, object>> SortByDescending { get; private set; }


    protected void IncludeMethod(Expression<Func<T, object>> expression)
    {
        Include.Add(expression);
    }

    protected void SortByAscendingMethod(Expression<Func<T, object>> sortExpression)
    {
        SortByAscending = sortExpression;
    }

    protected void SortByDescendingMethod(Expression<Func<T, object>> sortDescendingExpression)
    {
        SortByDescending = sortDescendingExpression;
    }
}