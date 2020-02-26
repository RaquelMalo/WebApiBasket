using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebApiBasket.Domain;

namespace WebApiBasket.Services.Repository
{
    public class EfGenericRepository<T>:IEfGenericRepository<T> where T: class
    {
        public BasketContext DbContext = null;
        public DbSet<T> Table = null;

        public EfGenericRepository()
        {
            DbContext = new BasketContext();
            Table = DbContext.Set<T>();
        }

        public EfGenericRepository(BasketContext context)
        {
            DbContext = context;
            Table = DbContext.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await Table.ToListAsync().ConfigureAwait(false);
        }

        //public async Task<T> GetElement(params object[] keys)
        //{
        //    if (keys.All(id => id == null))
        //    {
        //        //log with HttpStatusCode.BadRequest
        //        //ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
        //        return null;
        //    }
        //    return await Table.FindAsync(keys);
        //}

        public async Task Insert(T obj)
        {
            Table.Add(obj);
            await Save().ConfigureAwait(false);
        }

        //public async Task Update(T obj)
        //{
        //    Table.Attach(obj);
        //    DbContext.Entry(obj).State = EntityState.Modified;
        //    await Save().ConfigureAwait(false);
        //}

        public async Task Delete(params object[] id)
        {
            var obj = await Table.FindAsync(id).ConfigureAwait(false);
            if (obj != null)
                await Task.Run(() => Table.Remove(obj));
            await Save().ConfigureAwait(false);
        }

        public async Task TruncateDb()
        {
            await Task.Run(() => Table.RemoveRange(Table));
            await Save().ConfigureAwait(false);
        }

        public async Task Save()
        {
            await DbContext.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}