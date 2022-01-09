using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfApplicationJobDal : EfEntityRepositoryBase<ApplicationJob, NorthwindContext>, IApplicationJobDal
    {
        public List<ApplicationDetailEmployerAndImageDto> GetAllEmployerByApplicationJobDetails(int JobId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from aj in context.ApplicationJobs
                             join e in context.Employers on aj.EmployerId equals e.EmployerId
                             join i in context.Images on e.UserId equals i.UserId
                             where aj.JobId == JobId

                             select new ApplicationDetailEmployerAndImageDto
                             {
                                   EmployerId = e.EmployerId,
                                   UserId = e.UserId,
                                   EmployerName = e.EmployerName,
                                   EmployerSurName = e.EmployerSurname,
                                   ImagePath = i.ImagePath
                                   
                             };
                return result.ToList();
            }
        }

        public List<ApplicationDetailDto> GetJobDetails(int userId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from aj in context.ApplicationJobs
                             join j in context.Jobs on aj.JobId equals j.JobId
                             join c in context.Companies on  aj.CompanyId equals c.CompanyId
                             join i in context.Images on c.UserId equals i.UserId
                             where aj.UserId == userId

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
                                 FavStatus = j.FavStatus,
                                 ImagePath = i.ImagePath

                             };
                return result.ToList();
            }
        }

        public List<ApplicationDetailDto> GetJobDetailsForCompany(int companyId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from aj in context.ApplicationJobs
                             join j in context.Jobs on aj.JobId equals j.JobId
                             join c in context.Companies on aj.CompanyId equals c.CompanyId
                             join i in context.Images on c.UserId equals i.UserId
                             where aj.CompanyId == companyId

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
                                 FavStatus = j.FavStatus,
                                 ImagePath = i.ImagePath

                             };
                return result.ToList();
            }
        }
    }
}
