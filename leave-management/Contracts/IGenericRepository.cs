using System.Collections.Generic;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllSync();
        Task<T> AddSync(T entity);
        Task<bool> Exists(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
    }
}


//is <T> a collection?