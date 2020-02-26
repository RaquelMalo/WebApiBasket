using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiBasket.Services.Repository
{
    public interface IEfGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        //Task<T> GetElement(params object[] keys);
        Task Insert(T obj);
        //Task Update(T obj);
        Task Delete(params object[] keys);
        Task TruncateDb();
        Task Save();
    }
}
