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
    public class FavoriteJobManager : IFavoriteJobService
    {
        IFavoriteJobDal _favoritejobDal;
        //IUserTypeService _userTypeService;
        public FavoriteJobManager(IFavoriteJobDal favoritejobDal)
        {
            //bir entity manager kendisi hariç bir başka dalı enjekte edemez.
            //service enjekte ederek yapabiliriz.
            _favoritejobDal = favoritejobDal;

        }
        public IResult Add(FavoriteJob FavoriteJob)
        {
            _favoritejobDal.Add(FavoriteJob);
            return new SuccessResult(Messages.FavoriteJobAdded);
        }

        public IResult Delete(FavoriteJob FavoriteJob)
        {
            var deletedFavJob = _favoritejobDal.Get(f => f.EmployerId == FavoriteJob.EmployerId && f.JobId == FavoriteJob.JobId);
            FavoriteJob.FavoriteJobId = deletedFavJob.FavoriteJobId;
            _favoritejobDal.Delete(FavoriteJob);
            return new SuccessResult(Messages.FavoriteJobDeleted);
        }

        public IDataResult<List<FavoriteJob>> GetAllByEmployerId(int EmployerId)
        {
            return new SuccessDataResult<List<FavoriteJob>>(_favoritejobDal.GetAll(j => j.EmployerId == EmployerId));

        }

        public IDataResult<FavoriteJob> GetByFavoriteJobId(int FavoriteJobId)
        {
            return new SuccessDataResult<FavoriteJob>(_favoritejobDal.Get(j => j.FavoriteJobId == FavoriteJobId));
        }

        public IDataResult<FavoriteJob> GetByJobId(int jobId)
        {
            return new SuccessDataResult<FavoriteJob>(_favoritejobDal.Get(j => j.JobId == jobId));
        }

        public IDataResult<List<JobDetailDto>> GetJobDetails(int employerId)
        {
            return new SuccessDataResult<List<JobDetailDto>>(_favoritejobDal.GetJobDetails(employerId));
        }


    }
}
