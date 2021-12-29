using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IDraftJobService
    {
        IDataResult<List<DraftJob>> GetAll(); //void+data
        IDataResult<List<DraftJob>> GetAllByCompanyId(int id);
        IDataResult<List<DraftJobDetailDto>> GetJobDetails();
        IDataResult<DraftJob> GetById(int DraftJobId);
        IResult Add(DraftJob DraftJob); //void
        //void oldugu icin idataresult yapmadık (void fonksiyon oldugu icin)
        IResult Update(DraftJob DraftJob);
        IResult Delete(DraftJob DraftJob);

        //RESTFUL --> HTTP -->
    }
}