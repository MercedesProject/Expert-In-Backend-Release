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
    public class SaveSkillManager : ISaveSkillService
    {
        ISaveSkillDal _saveSkillDal;

        public SaveSkillManager(ISaveSkillDal saveSkillDal)
        {
            _saveSkillDal = saveSkillDal;

        }
        public IResult Add(SaveSkill SaveSkill)
        {
            _saveSkillDal.Add(SaveSkill);
            return new SuccessResult(Messages.SaveSkillAdded);
        }

        public IDataResult<List<SaveSkill>> GetAllByEmployerId(int id)
        {
            return new SuccessDataResult<List<SaveSkill>>(_saveSkillDal.GetAll(s => s.EmployerId == id));
        }

        public IDataResult<List<SaveSkillDetailDto>> GetSaveSkillDetails()
        {
            return new SuccessDataResult<List<SaveSkillDetailDto>>(_saveSkillDal.GetSaveSkillDetails());
        }
    }
}
