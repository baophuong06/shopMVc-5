using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
//using System.Xml.Linq.;

namespace eShopMVC.Data.Infrastructure
{
   public interface IRespository<T> where T : class
    {
        T Add(T entity);
        void Update(T entity);
        T Delete(T entity);
        void DeleteMulti(Expression<Func<T, bool>> where);

        T GetSingleByID(int id);
        T Delete(int id);
        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);
        IEnumerable<T> GetAll(string[] includes = null);
        IEnumerable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);
        IEnumerable<T> GetMultiPaging(Expression<Func<T, bool>> filter,out int total,int index=0,int size=50,string[] includes = null);
        int Count(Expression<Func<T, bool>> where);
        bool CheckContain(Expression<Func<T, bool>> predicate);

    }
}
