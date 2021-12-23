using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Education : IEntity
    {
        public int EducationId { get; set; } //PK
        public int EmployerId { get; set; } //FK
        public String EducationSchool { get; set; }
        public String EducationDegree { get; set; }
        public String EducationStudy { get; set; }
        public DateTime EducationStartingDate { get; set; }
        public DateTime EducationEndingDate { get; set; }
        public Boolean EducationCurrentStatus { get; set; }//diagramda yok?
    }
}
