using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFavoriteJobService
    {
        //IDataResult<List<FavoriteJob>> GetAll(); //void+data
        IDataResult<List<FavoriteJob>> GetAllByEmployerId(int id);
        //IDataResult<List<FavoriteJobDetailDto>> GetJobDetails();
        IDataResult<FavoriteJob> GetByFavoriteJobId(int FavoriteJobId);
        IDataResult<FavoriteJob> GetByJobId(int jobId);
        IResult Add(FavoriteJob FavoriteJob); //void
        //void oldugu icin idataresult yapmadık (void fonksiyon oldugu icin)
        //IResult Update(FavoriteJob FavoriteJob);
        IResult Delete(FavoriteJob FavoriteJob);

        //RESTFUL --> HTTP -->
    }
}
