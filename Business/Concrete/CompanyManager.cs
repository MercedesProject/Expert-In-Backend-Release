using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        ICompanyDal _companyDal;
        //IUserTypeService _userTypeService;

        public CompanyManager(ICompanyDal companyDal)
        {
            //bir entity manager kendisi hariç bir başka dalı enjekte edemez.
            //service enjekte ederek yapabiliriz.
            _companyDal = companyDal;

        }
        public IResult Add(Company Company)
        {
            _companyDal.Add(Company);
            return new SuccessResult(Messages.CompanyAdded);
        }

        public IDataResult<List<Company>> GetAll()
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetAll(), Messages.CompaniesListed);
        }

        public IDataResult<Company> GetById(int UserId)
        {
            return new SuccessDataResult<Company>(_companyDal.Get(j => j.UserId == UserId));
        }public IDataResult<Company> GetByCompanyId(int CompanyId)
        {
            return new SuccessDataResult<Company>(_companyDal.Get(j => j.CompanyId == CompanyId));
        }

        public IResult Update(Company company)
        {
            _companyDal.Update(company);
            return new SuccessResult(Messages.CompanyUpdated);
        }
        
        public IResult Delete(Company company)
        {
            _companyDal.Delete(company);
            return new SuccessResult(Messages.CompanyDeleted);
        }
    }
}
