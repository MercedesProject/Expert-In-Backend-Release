using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IEmployerService
    {
        IDataResult<List<Employer>> GetAll(); //void+data
        IDataResult<List<Employer>> GetAllByUserTypeId(int id);
        IDataResult<List<EmployerDetailDto>> GetEmployerDetails();
        IDataResult<Employer> GetById(int EmployerId);
        IResult Add(Employer employer); //void
        //void oldugu icin idataresult yapmadık (void fonksiyon oldugu icin)
        IResult Update(Employer employer);

        //RESTFUL --> HTTP -->
    }
}