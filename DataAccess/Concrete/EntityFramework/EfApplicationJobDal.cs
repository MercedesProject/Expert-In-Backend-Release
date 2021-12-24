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
    public class EfApplicationJobDal : EfEntityRepositoryBase<ApplicationJob, NorthwindContext>, IApplicationJobDal
    {
        public List<ApplicationDetailDto> GetApplicationJobDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from aj in context.ApplicationJobs
                             join j in context.Jobs
                             on aj.JobId equals j.JobId
                             select new ApplicationDetailDto
                             {
                                 EmployerId = aj.EmployerId,
                                 JobName = j.JobName,
                                 ApplicationJobStatus = aj.ApplicationJobStatus
                             };
                return result.ToList();
            }
        }
    }
}
