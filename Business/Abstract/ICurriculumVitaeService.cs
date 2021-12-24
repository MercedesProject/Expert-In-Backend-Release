using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICurriculumVitaeService
    {
        IResult Add(IFormFile file, CurriculumVitae curriculumVitae);
        IResult Delete(CurriculumVitae curriculumVitae);
        IDataResult<List<CurriculumVitae>> GetImagesByUserId(int id);
    }
}
