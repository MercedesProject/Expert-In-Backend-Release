using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.DTOs
{
    public class DraftJobDetailDto : IDto
    {
        public String CompanyName { get; set; }
        public String CompanyLocation { get; set; }
        public int JobId { get; set; } //PK
        public int CompanyId { get; set; } //FK
        public String JobName { get; set; }
        public String JobDescription { get; set; }
        public String JobType { get; set; } //frontendbackend
        public String JobForm { get; set; } //hibrit remote işyerinde
        public int JobSalary { get; set; } //diagramda string denmiş sor
        public String JobStartDate { get; set; }
        public String JobEndDate { get; set; }
        public String JobApplyLastDate { get; set; }
        public int JobWeekDay { get; set; }
    }
}

