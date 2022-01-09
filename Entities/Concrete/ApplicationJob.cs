using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ApplicationJob : IEntity
    {
        public int ApplicationJobId { get; set; } //PK
        public int JobId { get; set; } //FK
        public int EmployerId { get; set; } //FK
        public int CompanyId { get; set; } //FK
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public string JobType { get; set; } //frontendbackend
        public string JobForm { get; set; } //hibrit remote işyerinde
        public int JobSalary { get; set; }//diagramda string denmiş sor
        public string JobStartDate { get; set; }
        public string JobEndDate { get; set; }
        public string JobApplyLastDate { get; set; }
        public int JobWeekDay { get; set; }
        public bool FavStatus { get; set; } //default 0 favlanmamış demek ---> insert fav table + set FavStatus column 1
        public string ApplicationJobStatus { get; set; }
        public int UserId { get; set; }
    }
}
