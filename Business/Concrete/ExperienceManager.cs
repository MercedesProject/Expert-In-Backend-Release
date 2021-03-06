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
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;
        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }
        public IResult Add(Experience experience)
        {
            _experienceDal.Add(experience);
            return new SuccessResult(Messages.ExperienceAdded);
        }

        public IResult Delete(Experience experience)
        {
            _experienceDal.Delete(experience);
            return new SuccessResult(Messages.ExperienceDeleted);
        }

        public IDataResult<List<Experience>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Experience>> GetAllByEmployerId(int id)
        {
            var employerCount = _experienceDal.GetAll(e => e.EmployerId == id).Count;

            if (employerCount == 0)
            {
                return new ErrorDataResult<List<Experience>>("bu kullanıcının experiencesi bulunmamaktadır.");
            }

            return new SuccessDataResult<List<Experience>>(_experienceDal.GetAll(e => e.EmployerId == id));
        }

        public IResult Update(Experience experience)
        {
            _experienceDal.Update(experience);
            return new SuccessResult(Messages.ExperienceUpdated);
        }
    }
}
