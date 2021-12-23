using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //company data accesess layer
    public interface ICompanyDal : IEntityRepository<Company>
    {
        //we dont need anymore cause of IEntityRepository<Company>
        //List<Company> GetAll();
        //void Add(Company company); //sisteme kayıt
        //void Update(Company company); //güncelleme
        //void Delete(Company company); //silme 

    }
}
