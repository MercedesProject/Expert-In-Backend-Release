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
        public String ApplicationJobStatus { get; set; }
    }
}
