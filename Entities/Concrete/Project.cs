using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Project : IEntity
    {
        public int ProjectId { get; set; } //PK
        public int EmployerId { get; set; } //FK
        public String ProjectName { get; set; }
        public DateTime ProjectStartingDate { get; set; }
        public DateTime ProjectEndingDate { get; set; }
        public Boolean ProjectCurrentStatus { get; set; }//diagramda sadece  current
        public String ProjectDescription { get; set; }
        public String ProjectUrl { get; set; }
    }
}
