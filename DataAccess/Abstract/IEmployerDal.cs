using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //employer data accesess layer
    public interface IEmployerDal : IEntityRepository<Employer>
    {
        ////we dont need anymore cause of IEntityRepository<Employer>
        //List<Employer> GetAll();
        //void Add(Employer employer); //sisteme kayıt
        //void Update(Employer employer); //güncelleme
        //void Delete(Employer employer); //silme 

        List<EmployerDetailDto> GetEmployerDetails();

    }
}