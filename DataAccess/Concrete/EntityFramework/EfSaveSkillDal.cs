using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSaveSkillDal : EfEntityRepositoryBase<SaveSkill, NorthwindContext>, ISaveSkillDal
    {
        public List<SaveSkillDetailDto> GetSaveSkillDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from ss in context.SaveSkills 
                             join s in context.Skills
                             on ss.SkillId equals s.SkillId
                             join e in context.Employers
                             on ss.EmployerId equals e.EmployerId

                             select new SaveSkillDetailDto
                             {
                                 SkillName = s.SkillName,
                                 EmployerId = e.EmployerId,
                                 EmployerName = e.EmployerName
                             };
                return result.ToList();
            }
        }
    }
}
