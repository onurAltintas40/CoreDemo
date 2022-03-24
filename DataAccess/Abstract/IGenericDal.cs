
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        T GetById(int id);
        List<T> GetListAll();
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
    }
}
