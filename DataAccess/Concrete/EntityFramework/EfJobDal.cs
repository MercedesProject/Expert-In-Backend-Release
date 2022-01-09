using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfJobDal : EfEntityRepositoryBase<Job, NorthwindContext>, IJobDal
    {
        public List<JobDetailDto> GetJobDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from j in context.Jobs
                             join c in context.Companies
                             on j.CompanyId equals c.CompanyId
                             join i in context.Images
                             on c.UserId equals i.UserId
                             select new JobDetailDto
                             {
                                 CompanyName = c.CompanyName,
                                 CompanyLocation = c.CompanyLocation,
                                 JobId = j.JobId,
                                 CompanyId = j.CompanyId,
                                 JobName = j.JobName,
                                 JobDescription = j.JobDescription,
                                 JobType = j.JobType,
                                 JobForm = j.JobForm,
                                 JobSalary = j.JobSalary,
                                 JobStartDate = j.JobStartDate,
                                 JobEndDate = j.JobEndDate,
                                 JobApplyLastDate = j.JobApplyLastDate,
                                 JobWeekDay = j.JobWeekDay,
                                 FavStatus = j.FavStatus,
                                 ImagePath = i.ImagePath
                             }; 
                return result.ToList();
            }
        }

    }
}
