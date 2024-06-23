namespace Entity.Interfaces;

public interface IGenericRepository<T>
{
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T> GetByIdAsync(dynamic id);
}