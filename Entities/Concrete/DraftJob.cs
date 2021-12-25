using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DraftJob : IEntity
    {
        public int DraftJobId { get; set; } //PK
        public int CompanyId { get; set; } //FK
        public String DraftJobName { get; set; }
        public String DraftJobDescription { get; set; }
        public String DraftJobType { get; set; } //frontendbackend
        public String DraftJobForm { get; set; } //hibrit remote işyerinde
        public int DraftJobSalary { get; set; }//diagramda string denmiş sor
        public DateTime DraftJobStartDate { get; set; }
        public DateTime DraftJobEndDate { get; set; }
        public DateTime DraftJobApplyLastDate { get; set; }
        public int DraftJobWeekDay { get; set; }
    }
}

