using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfImageDal : EfEntityRepositoryBase<Image, NorthwindContext>, IImageDal
    {
    }
}