using leave_management.Contracts;
using leave_management.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class GenericRepositorty<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;

        public GenericRepositorty(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<T> AddSync(T entity)
        {
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);             // This one is similar to LeaveTypesController Delete Action except in this one we repleace
            context.Set<T>().Remove(entity);             // LeaveTypes with Set<T> because it's generic type (in generic repository) and we also use 
            await context.SaveChangesAsync();            // entity as var instead of leaveType
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await GetAsync(id);
            return entity != null;
        }

        public async Task<List<T>> GetAllSync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            context.Update(entity);
            //context.Entry(entity).State = EntityState.Modified;  //this is just another way of writing the line above
            await context.SaveChangesAsync();
        }
    }
}
