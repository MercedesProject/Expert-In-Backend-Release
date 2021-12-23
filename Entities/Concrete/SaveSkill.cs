using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SaveSkill : IEntity //class ismi sor
    {
        public int SaveSkillId { get; set; } //PK
        public int SkillId { get; set; } //FK
        public int EmployerId { get; set; } //FK
    }
}
