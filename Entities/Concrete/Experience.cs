using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Experience : IEntity
    {
        public int ExperienceId { get; set; } //PK
        public int EmployerId { get; set; } //FK
        public String ExperienceTitle { get; set; }
        public String ExperienceCompanyName { get; set; }//diagrammda firm name sor
        public int ExperienceLocation { get; set; }
        public DateTime ExperienceStartingDate { get; set; }
        public DateTime ExperienceEndingDate { get; set; }
        public Boolean ExperienceCurrentStatus { get; set; }//diagramda sadece  current
        public String ExperienceDescription { get; set; }
    }
}
