using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DraftJob : IEntity
    {
        [Key]
        public int JobId { get; set; } //PK
        public int CompanyId { get; set; } //FK
        public String JobName { get; set; }
        public String JobDescription { get; set; }
        public String JobType { get; set; } //frontendbackend
        public String JobForm { get; set; } //hibrit remote işyerinde
        public int JobSalary { get; set; }//diagramda string denmiş sor
        public String JobStartDate { get; set; }
        public String JobEndDate { get; set; }
        public String JobApplyLastDate { get; set; }
        public int JobWeekDay { get; set; }
    }
}

