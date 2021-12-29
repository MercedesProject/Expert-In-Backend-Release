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
    public class EfDraftJobDal : EfEntityRepositoryBase<DraftJob, NorthwindContext>, IDraftJobDal
    {
        public List<DraftJobDetailDto> GetJobDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from j in context.DraftJobs
                             join c in context.Companies
                        on j.CompanyId equals c.CompanyId
                    select new DraftJobDetailDto
                    {
                        CompanyName = c.CompanyName,
                        CompanyLocation = c.CompanyLocation,
                        JobId = j.JobId,
                        JobName = j.JobName,
                        JobDescription = j.JobDescription,
                        JobType = j.JobType,
                        JobForm = j.JobForm,
                        JobSalary = j.JobSalary,
                        //JobStartDate = j.JobStartDate,
                        //JobEndDate = j.JobEndDate,
                        //JobApplyLastDate = j.JobApplyLastDate,
                        //JobWeekDay = j.JobWeekDay
                    };
                return result.ToList();
            }
        }
    }
}