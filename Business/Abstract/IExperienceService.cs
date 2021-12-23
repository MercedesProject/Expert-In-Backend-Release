using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IExperienceService
    {
        IDataResult<List<Experience>> GetAll(); //void+data
        IDataResult<List<Experience>> GetAllByEmployerId(int id);
        IResult Add(Experience experience); //void
        IResult Update(Experience experience);
        IResult Delete(Experience experience);
    }
}
