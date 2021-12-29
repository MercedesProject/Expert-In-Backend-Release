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
    public class DraftJobManager : IDraftJobService
    {
        IDraftJobDal _DraftJobDal;
        //IUserTypeService _userTypeService;

        public DraftJobManager(IDraftJobDal DraftJobDal)
        {
            //bir entity manager kendisi hariç bir başka dalı enjekte edemez.
            //service enjekte ederek yapabiliriz.
            _DraftJobDal = DraftJobDal;

        }
        public IResult Add(DraftJob DraftJob)
        {
            _DraftJobDal.Add(DraftJob);
            return new SuccessResult(Messages.DraftJobAdded);
        }

        public IResult Delete(DraftJob DraftJob)
        {
            _DraftJobDal.Delete(DraftJob);
            return new SuccessResult(Messages.DraftJobAdded);
        }


        public IDataResult<List<DraftJob>> GetAll()
        {
            if (DateTime.Now.Hour == 19)
            {
                return new ErrorDataResult<List<DraftJob>>(Messages.MaintenanceTime);
            }
            //İş kodları
            return new SuccessDataResult<List<DraftJob>>(_DraftJobDal.GetAll(), Messages.DraftJobsListed);
        }

        public IDataResult<List<DraftJob>> GetAllByCompanyId(int id)
        {
            return new SuccessDataResult<List<DraftJob>>(_DraftJobDal.GetAll(j => j.CompanyId == id));
        }

        public IDataResult<DraftJob> GetById(int DraftJobId)
        {
            return new SuccessDataResult<DraftJob>(_DraftJobDal.Get(j => j.JobId == DraftJobId));
        }

        public IResult Update(DraftJob DraftJob)
        {
            //eksik
            throw new NotImplementedException();
        }

        public IDataResult<List<DraftJobDetailDto>> GetJobDetails()
        {
            if (DateTime.Now.Hour == 16)
            {
                return new ErrorDataResult<List<DraftJobDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<DraftJobDetailDto>>(_DraftJobDal.GetJobDetails());
        }

    }
}