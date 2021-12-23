using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IEducationService
    {
        IDataResult<List<Education>> GetAll(); //void+data
        IDataResult<List<Education>> GetAllByEmployerId(int id);
        IResult Add(Education education); //void
        IResult Update(Education education);
        IResult Delete(Education education);
    }
}
