using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployerManager : IEmployerService
    {
        IEmployerDal _employerDal;
        IUserTypeService _userTypeService;

        public EmployerManager(IEmployerDal employerDal, IUserTypeService userTypeService)
        {
            //bir entity manager kendisi hariç bir başka dalı enjekte edemez.
            //service enjekte ederek yapabiliriz.
            _employerDal = employerDal;
            _userTypeService = userTypeService;

        }

        [ValidationAspect(typeof(EmployerValidator))] //Attiribute sayesinde methodlarımza anlam katarız.
        //[SecuredOperation("employer.add,admin")]
        public IResult Add(Employer employer)
        {
            //Business Code ex. if not exist add
            IResult result = BusinessRules.Run();

            if (result != null)
            {
                return result;
            }

            _employerDal.Add(employer);
            return new SuccessResult(Messages.EmployerAdded);

        }

        public IDataResult<List<Employer>> GetAll()
        {
            if (DateTime.Now.Hour == 19)
            {
                return new ErrorDataResult<List<Employer>>(Messages.MaintenanceTime);
            }
            //İş kodları
            return new SuccessDataResult<List<Employer>>(_employerDal.GetAll(), Messages.EmployersListed);
            //return _employerDal.GetAll(e => e.EmployerId ==3); idsi 3 olan employerı getirmek için Expression
        }

        public IDataResult<List<Employer>> GetAllByUserTypeId(int id)
        {
            return new SuccessDataResult<List<Employer>>(_employerDal.GetAll(e => e.UserTypeId == id));
        }

        public IDataResult<Employer> GetById(int employerId)
        {
            return new SuccessDataResult<Employer>(_employerDal.Get(e => e.EmployerId == employerId));
        }

        public IDataResult<List<EmployerDetailDto>> GetEmployerDetails()
        {
            if (DateTime.Now.Hour == 16)
            {
                return new ErrorDataResult<List<EmployerDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<EmployerDetailDto>>(_employerDal.GetEmployerDetails());
        }
        [ValidationAspect(typeof(EmployerValidator))]
        public IResult Update(Employer employer)
        {
            _employerDal.Update(employer);
            return new SuccessResult(Messages.EmployerUpdated);
        }

        //bu sadece bi örnek -- max 15 şirket veya employer olabilir 
        //private IResult CheckIfEmployerCountOfUserTypeCorrect(int userTypeId)
        //{
        //    //Select count(*) from employers where categoryId=1
        //    var result = _employerDal.GetAll(e => e.UserTypeId == userTypeId).Count;
        //    if (result >= 15)
        //    {
        //        return new ErrorResult(Messages.ProductCountOfCategoryError);
        //    }
        //    return new SuccessResult();
        //}

        //bu sadece bi örnek -- aynı isimde başka employer olamaz
        private IResult CheckIfEmployerNameExists(string employerName)
        {
            //Select count(*) from products where categoryId=1
            var result = _employerDal.GetAll(e => e.EmployerName == employerName).Any();
            if (result == true)
            {
                return new ErrorResult(Messages.EmployerNameALreadyExists);
            }
            return new SuccessResult();
        }

        //başka classtan örnek
        //bir UserTypedan max 15
        private IResult CheckIfUserTypeLimitExceded()
        {
            var result = _userTypeService.GetAll();
            if (result.Data.Count > 15)
            {
                return new ErrorResult(Messages.UserTypeLimitExceded);
            }

            return new SuccessResult();
        }
        //yeni bir iş kuralı eklendiğinde BusinessRules.Runa eklmek yeterli 

    }
}