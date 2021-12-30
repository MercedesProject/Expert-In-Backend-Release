using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Job : IEntity
    {
        public int JobId { get; set; } //PK
        public int CompanyId { get; set; } //FK
        public String JobName { get; set; }
        public String JobDescription { get; set; }
        public String JobType { get; set; } //frontendbackend
        public String JobForm { get; set; } //hibrit remote işyerinde
        public int JobSalary { get; set; }//diagramda string denmiş sor
        public DateTime JobStartDate { get; set; }
        public DateTime JobEndDate { get; set; }
        public DateTime JobApplyLastDate { get; set; }
        public int JobWeekDay { get; set; }
        public bool FavStatus { get; set; } //default 0 favlanmamış demek ---> insert fav table + set FavStatus column 1
    }
}
