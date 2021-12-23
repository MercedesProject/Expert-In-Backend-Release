using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Certificate : IEntity
    {
        public int CertificateId { get; set; } //PK
        public int EmployerId { get; set; } //FK
        public String CertificateTitle { get; set; }
        public String CertificateDescription { get; set; }
    }
}
