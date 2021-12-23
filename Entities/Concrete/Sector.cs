using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Sector : IEntity
    {
        public int SectorId { get; set; }
        public String SectorName { get; set; }
    }
}
