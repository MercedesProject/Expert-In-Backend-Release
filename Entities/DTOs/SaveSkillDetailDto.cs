using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class SaveSkillDetailDto : IDto
    {
        public String SkillName { get; set; }
        public String EmployerName { get; set; }
        public int EmployerId { get; set; }
    }
}
