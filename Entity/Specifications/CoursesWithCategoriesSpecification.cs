using System.Linq.Expressions;

namespace Entity.Specifications;

public class CoursesWithCategoriesSpecification : BaseSpecification<Course>
{
    public CoursesWithCategoriesSpecification(string sort)
    {
        IncludeMethod(x => x.Category);
        if (!string.IsNullOrEmpty(sort))
        {
            switch (sort)
            {
                case "priceAscending":
                    SortByAscendingMethod(c => c.Price);
                    break;
                case "priceDescending":
                    SortByDescendingMethod(c => c.Price);
                    break;
                default:
                    SortByAscendingMethod(c => c.Title);
                    break;
            }
        }
    }

    public CoursesWithCategoriesSpecification(Guid id) : base(x => x.Id == id)
    {
        IncludeMethod(x => x.Requirements);
        IncludeMethod(x => x.Learning);
    }
}