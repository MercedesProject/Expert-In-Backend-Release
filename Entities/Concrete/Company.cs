using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Company : IEntity
    {
        public int CompanyId { get; set; } //PK
        public int UserTypeId { get; set; } //FK
        public int UserId { get; set; } //FK
        public int SectorId { get; set; } //FK
        public String CompanyName { get; set; }
        public String CompanyLocation { get; set; }
        public int CompanyPhoneNumber { get; set; } //diagramda eksik burada olacak mı
        public String CompanyEMail { get; set; }
        public String CompanyWebSite { get; set; }
        public String CompanyDescription { get; set; }
        public String CompanyPhoto { get; set; }
        public String CompanyCity { get; set; }
        public String CompanyCountry { get; set; }


    }
}
