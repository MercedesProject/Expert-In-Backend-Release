using System;
using Core.Entities;

namespace Entities.DTOs
{
    public class ApplicationDetailDto : IDto
    {
        
        public int EmployerId { get; set; }
        public String JobName { get; set; } 
        public String ApplicationJobStatus { get; set; }
        public String CompanyName { get; set; }
        public String CompanyLocation { get; set; }
        public int JobId { get; set; } //PK
        public int CompanyId { get; set; } //FK
        public String JobDescription { get; set; }
        public String JobType { get; set; } //frontendbackend
        public String JobForm { get; set; } //hibrit remote işyerinde
        public int JobSalary { get; set; }//diagramda string denmiş sor
        public DateTime JobStartDate { get; set; }
        public DateTime JobEndDate { get; set; }
        public DateTime JobApplyLastDate { get; set; }
        public int JobWeekDay { get; set; }
        public bool FavStatus { get; set; }
    }

    public class ApplicationDetailEmployerAndImageDto : IDto
    {

        public int EmployerId { get; set; }
        public int UserId { get; set; }
        public String EmployerName { get; set; }
        public String EmployerSurName { get; set; }
        public String ImagePath { get; set; }
        
    }
}