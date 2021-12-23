using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UserType : IEntity
    {
        //0,Employer - 1,Company
        public int UserTypeId { get; set; }
        public String UserTypeCategory { get; set; }
    }
}
