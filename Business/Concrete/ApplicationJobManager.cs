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
    public class ApplicationJobManager : IApplicationJobService
    {
        IApplicationJobDal _applicationJobDal;
        public ApplicationJobManager(IApplicationJobDal applicationJobDal)
        {
            _applicationJobDal = applicationJobDal;

        }
        public IResult Add(ApplicationJob applicationJob)
        {
            _applicationJobDal.Add(applicationJob);
            return new SuccessResult(Messages.ApplicationReceived);
        }

        public IResult Delete(ApplicationJob applicationJob)
        {
            _applicationJobDal.Delete(applicationJob);
            return new SuccessResult(Messages.ApplicationCancel);
        }

        public IDataResult<List<ApplicationJob>> GetAllByEmployerId(int id)
        {
            return new SuccessDataResult<List<ApplicationJob>>(_applicationJobDal.GetAll(j => j.EmployerId == id));
        }

        public IDataResult<List<ApplicationJob>> GetByAppliedJobId(int jobId)
        {
            return new SuccessDataResult<List<ApplicationJob>>(_applicationJobDal.GetAll(j => j.JobId == jobId));
        }
    }
}
