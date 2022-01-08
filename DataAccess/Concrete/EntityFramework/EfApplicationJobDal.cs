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
        public List<ApplicationDetailDto> GetJobDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from aj in context.ApplicationJobs
                             join j in context.Jobs on aj.JobId equals j.JobId
                             join c in context.Companies on  aj.CompanyId equals c.CompanyId
                            
                             select new ApplicationDetailDto
                             {
                                 CompanyLocation = c.CompanyLocation,
                                 CompanyName = c.CompanyName,
                                 EmployerId = aj.EmployerId,
                                 JobName = j.JobName,
                                 ApplicationJobStatus = aj.ApplicationJobStatus,
                                 JobId = j.JobId,
                                 CompanyId = j.CompanyId,
                                 JobDescription = j.JobDescription,
                                 JobType = j.JobType,
                                 JobForm = j.JobForm,
                                 JobSalary = j.JobSalary,
                                 JobStartDate = j.JobStartDate,
                                 JobEndDate = j.JobEndDate,
                                 JobApplyLastDate = j.JobApplyLastDate,
                                 JobWeekDay = j.JobWeekDay,
                                 FavStatus = j.FavStatus

                             };
                return result.ToList();
            }
        }
    }
}
