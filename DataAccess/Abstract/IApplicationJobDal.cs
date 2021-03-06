using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IApplicationJobDal : IEntityRepository<ApplicationJob>
    {
        List<ApplicationDetailDto> GetJobDetails(int userId);
        List<ApplicationDetailDto> GetJobDetailsForCompany(int companyId);
        List<ApplicationDetailEmployerAndImageDto> GetAllEmployerByApplicationJobDetails(int JobId);
    }
}
