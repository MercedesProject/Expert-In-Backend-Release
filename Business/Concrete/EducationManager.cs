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
    public class EducationManager : IEducationService
    {
        IEducationDal _educationDal;

        public EducationManager(IEducationDal education)
        {
            _educationDal = education;

        }
        public IResult Add(Education education)
        {
            _educationDal.Add(education);
            return new SuccessResult(Messages.EducationAdded);
        }

        public IResult Delete(Education education)
        {
            _educationDal.Delete(education);
            return new SuccessResult(Messages.EducationDeleted);
        }

        public IDataResult<List<Education>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Education>> GetAllByEmployerId(int id)
        {
            return new SuccessDataResult<List<Education>>(_educationDal.GetAll(e => e.EmployerId == id));
        }

        public IResult Update(Education education)
        {
            _educationDal.Update(education);
            return new SuccessResult(Messages.EducationUpdated);
        }
    }
}
