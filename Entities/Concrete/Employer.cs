using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Employer : IEntity
    {
        public int EmployerId { get; set; } //PK
        public int UserTypeId { get; set; } //FK
        public int UserId { get; set; } //FK
        public String EmployerName { get; set; }
        public String EmployerSurname { get; set; }
        public String EmployerTitle { get; set; }
        public String EmployerCity { get; set; }
        public String EmployerCountry { get; set; }
        public String EmployerLocation { get; set; }
        public int EmployerPhoneNumber { get; set; }
        public String EmployerEMail { get; set; }
        public String EmployerGithub { get; set; }
        public String EmployerLinkedin { get; set; }
        public String EmployerAboutMe { get; set; }

    }
}