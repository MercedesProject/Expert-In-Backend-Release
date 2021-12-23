using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmployerDal : EfEntityRepositoryBase<Employer, NorthwindContext>, IEmployerDal
    {
        public List<EmployerDetailDto> GetEmployerDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from e in context.Employers
                             join u in context.UserTypes
                             on e.UserTypeId equals u.UserTypeId
                             select new EmployerDetailDto
                             {
                                 EmployerId = e.EmployerId,
                                 EmployerName = e.EmployerName,
                                 UserTypeCategory = u.UserTypeCategory
                             };
                return result.ToList();
            }
        }
    }
}