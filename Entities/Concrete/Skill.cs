using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Skill : IEntity
    {
        public int SkillId { get; set; }
        public String SkillName { get; set; }
    }
}
