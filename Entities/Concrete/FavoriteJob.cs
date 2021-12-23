using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class FavoriteJob : IEntity
    {
        public int FavoriteJobId { get; set; } //PK
        public int JobId { get; set; } //FK diagrammda bu fk değil
        public int EmployerId { get; set; } ////FK
    }
}
