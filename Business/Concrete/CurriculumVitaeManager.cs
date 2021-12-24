using Business.Abstract;
using Business.Constants;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CurriculumVitaeManager : ICurriculumVitaeService
    {
        ICurriculumVitaeDal _curriculumVitaeDal;
        IFileHelper _fileHelper;

        public CurriculumVitaeManager(ICurriculumVitaeDal curriculumVitaeDal, IFileHelper fileHelper)
        {
            _curriculumVitaeDal = curriculumVitaeDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(IFormFile file, CurriculumVitae curriculumVitae)
        {
            curriculumVitae.CurriculumVitaePath = _fileHelper.Upload(file, PathConstants.CurriculumVitaesPath);
            curriculumVitae.Date = DateTime.Now;

            _curriculumVitaeDal.Add(curriculumVitae);
            return new SuccessResult(Messages.CurriculumVitaeAdd);
        }

        public IResult Delete(CurriculumVitae curriculumVitae)
        {
            _fileHelper.Delete(PathConstants.CurriculumVitaesPath + curriculumVitae.CurriculumVitaePath);
            _curriculumVitaeDal.Delete(curriculumVitae);
            return new SuccessResult();
        }

        public IDataResult<List<CurriculumVitae>> GetImagesByUserId(int id)
        {
            return new SuccessDataResult<List<CurriculumVitae>>(_curriculumVitaeDal.GetAll(c => c.UserId == id));
        }
    }
}
