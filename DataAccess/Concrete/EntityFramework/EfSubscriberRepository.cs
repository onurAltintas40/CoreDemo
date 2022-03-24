
using DataAccess.Abstract;
using DataAccess.Repositories;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSubscriberRepository:GenericRepository<Subscriber>,ISubscriberDal
    {
    }
}
