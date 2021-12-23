using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    //bu bir IEntitiy değil -> bir database table değil
    //joinlenmiş hali -> DTO
    //Data Transformation Object
    public class EmployerDetailDto : IDto
    {
        public int EmployerId { get; set; } 
        public String EmployerName { get; set; }
        public String UserTypeCategory { get; set; }
    }
}
