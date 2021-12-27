using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICompanyService
    {
        IDataResult<List<Company>> GetAll(); //void+data
        //IDataResult<List<Company>> GetAllByUserTypeId(int id);
        //IDataResult<List<CompanyDetailDto>> GetCompanyDetails();
        IDataResult<Company> GetById(int CompanyId);
        IResult Add(Company Company);
        IResult Update(Company company);
        IResult Delete(Company company);
    }
}
