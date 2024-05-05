using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        Task Insert(T entity);  
        Task Delete(T entity);
        Task<IEnumerable<T>> GetAll(Expression<Func<bool>> filter);
        Task<IEnumerable<T>> GetAll();
        Task Update(T entity);
        Task<T> GetByID(int id);

    }
}
