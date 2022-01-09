using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicationJobService
    {
        IDataResult<List<ApplicationJob>> GetAllByEmployerId(int id); //çalışanın başvurduğu ilanlar
        IDataResult<List<ApplicationJob>> GetAllByUserId(int id);
        IDataResult<List<ApplicationDetailDto>> GetJobDetails(int id);
        IDataResult<List<ApplicationJob>> GetByAppliedJobId(int jobId);  // bir ilandaki başvuranlar
        IDataResult<List<ApplicationDetailEmployerAndImageDto>> GetAllEmployerAndPhotoByApplicationJobDetails(int JobId);
        IResult DuplicateApplication(int employerId);
        IResult Add(ApplicationJob applicationJob);
        IResult Delete(ApplicationJob applicationJob);
    }
}
