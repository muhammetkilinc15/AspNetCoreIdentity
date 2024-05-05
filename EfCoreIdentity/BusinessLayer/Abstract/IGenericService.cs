using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        Task<IEnumerable<T>> TGetAllAsync();
        Task<T> TGetByID(int id);
        Task TInsert(T entity); 
        Task TUpdate(T entity); 
        Task TDelete(T entity); 
    }
}
