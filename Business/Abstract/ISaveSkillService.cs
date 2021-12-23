using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISaveSkillService
    {
        IDataResult<List<SaveSkill>> GetAllByEmployerId(int id);
        IDataResult<List<SaveSkillDetailDto>> GetSaveSkillDetails();
        IResult Add(SaveSkill SaveSkill); 
    }
}
