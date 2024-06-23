using System.Linq.Expressions;

namespace Entity.Specifications;

public class CoursesWithCategoriesSpecification : BaseSpecification<Course>
{
    public CoursesWithCategoriesSpecification()
    {
        IncludeMethod(x => x.Category);
    }

    public CoursesWithCategoriesSpecification(Guid id) : base(x => x.Id == id)
    {
        IncludeMethod(x => x.Requirements);
        IncludeMethod(x => x.Learning);
    }
}