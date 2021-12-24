using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CurriculumVitae : IEntity
    {
        [Key]
        public int CurriculumVitaesId { get; set; }
        public int UserId { get; set; }
        public string CurriculumVitaePath { get; set; }
        public DateTime Date { get; set; }
    }
}
