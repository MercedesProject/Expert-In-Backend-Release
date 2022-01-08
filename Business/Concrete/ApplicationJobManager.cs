using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
        private IEmployerService _employerService;
        public ApplicationJobManager(IApplicationJobDal applicationJobDal, IEmployerService employerService)
        {
            _applicationJobDal = applicationJobDal;
            _employerService = employerService;

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

        public IResult DuplicateApplication(int employerId)
        {
            if (_employerService.GetById(employerId) != null)
            {
                return new ErrorResult(Messages.DuplicateApplication);
            }
            return new SuccessResult();
        }

        public IDataResult<List<ApplicationJob>> GetAllByEmployerId(int id)
        {
            return new SuccessDataResult<List<ApplicationJob>>(_applicationJobDal.GetAll(j => j.EmployerId == id));
        }

        public IDataResult<List<ApplicationJob>> GetAllByUserId(int id)
        {
            return new SuccessDataResult<List<ApplicationJob>>(_applicationJobDal.GetAll(j => j.UserId == id));
        }

        public IDataResult<List<ApplicationDetailDto>> GetJobDetails()
        {
          
            return new SuccessDataResult<List<ApplicationDetailDto>>(_applicationJobDal.GetJobDetails());
        }

        public IDataResult<List<ApplicationJob>> GetByAppliedJobId(int jobId)
        {
            return new SuccessDataResult<List<ApplicationJob>>(_applicationJobDal.GetAll(j => j.JobId == jobId));
        }
    }
}
