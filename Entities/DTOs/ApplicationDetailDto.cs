using System;

namespace Entities.DTOs
{
    public class ApplicationDetailDto
    {
        public int EmployerId { get; set; }
        public String EmployerName { get; set; }
        public String JobName { get; set; } 
        public String ApplicationJobStatus { get; set; }
    }
}