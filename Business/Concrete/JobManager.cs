using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class JobManager : IJobService
    {
        IJobDal _jobDal;
        //IUserTypeService _userTypeService;

        public JobManager(IJobDal jobDal)
        {
            //bir entity manager kendisi hariç bir başka dalı enjekte edemez.
            //service enjekte ederek yapabiliriz.
            _jobDal = jobDal;

        }
        public IResult Add(Job Job)
        {
            _jobDal.Add(Job);
            return new SuccessResult(Messages.JobAdded);
        }


        public IDataResult<List<Job>> GetAll()
        {
            if (DateTime.Now.Hour == 19)
            {
                return new ErrorDataResult<List<Job>>(Messages.MaintenanceTime);
            }
            //İş kodları
            return new SuccessDataResult<List<Job>>(_jobDal.GetAll(), Messages.JobsListed);
        }

        public IDataResult<List<Job>> GetAllByCompanyId(int id)
        {
            return new SuccessDataResult<List<Job>>(_jobDal.GetAll(j => j.CompanyId == id));
        }

        public IDataResult<Job> GetById(int JobId)
        {
            return new SuccessDataResult<Job>(_jobDal.Get(j => j.JobId == JobId));
        }

        public IResult Update(Job Job)
        {
            //eksik
            throw new NotImplementedException();
        }

        public IDataResult<List<JobDetailDto>> GetJobDetails()
        {
            if (DateTime.Now.Hour == 16)
            {
                return new ErrorDataResult<List<JobDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<JobDetailDto>>(_jobDal.GetJobDetails());
        }

    }
}
