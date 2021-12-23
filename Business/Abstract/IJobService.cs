using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IJobService
    {
        IDataResult<List<Job>> GetAll(); //void+data
        IDataResult<List<Job>> GetAllByCompanyId(int id);
        IDataResult<List<JobDetailDto>> GetJobDetails();
        IDataResult<Job> GetById(int JobId);
        IResult Add(Job Job); //void
        //void oldugu icin idataresult yapmadık (void fonksiyon oldugu icin)
        IResult Update(Job Job);

        //RESTFUL --> HTTP -->
    }
}
