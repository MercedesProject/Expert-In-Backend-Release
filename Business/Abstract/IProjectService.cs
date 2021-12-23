using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProjectService
    {
        IDataResult<List<Project>> GetAll(); //void+data
        IDataResult<List<Project>> GetAllByEmployerId(int id);
        IResult Add(Project project); //void
        IResult Update(Project project);
        IResult Delete(Project project);
    }
}
