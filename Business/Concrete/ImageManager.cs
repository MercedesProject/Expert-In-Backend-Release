using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ImageManager : IImageService
    {
        IImageDal _imageDal;
        IFileHelper _fileHelper;
        public ImageManager(IImageDal imageDal, IFileHelper fileHelper)
        {
            _imageDal = imageDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(IFormFile file, Image image)
        {
            image.ImagePath = _fileHelper.Upload(file, PathConstants.ImagesPath);
            image.Date = DateTime.Now;

            _imageDal.Add(image);
            return new SuccessResult(Messages.ImageAdd);
        }

        public IResult Delete(Image image)
        {
            _fileHelper.Delete(PathConstants.ImagesPath + image.ImagePath);
            _imageDal.Delete(image);
            return new SuccessResult();
        }

        public IDataResult<List<Image>> GetAll()
        {
            return new SuccessDataResult<List<Image>>(_imageDal.GetAll());
        }

        //public IDataResult<List<Image>> GetImagesByCompanyId(int id)
        //{
        //    var result = BusinessRules.Run();
        //    if (result != null)
        //    {
        //        return new ErrorDataResult<List<Image>>(GetDefaultImage(id).Data);
        //    }
        //    return new SuccessDataResult<List<Image>>(_imageDal.GetAll(i => i.Id == id));
        //}

        //public IDataResult<List<Image>> GetImagesByEmployerId(int id)
        //{
        //    var result = BusinessRules.Run();
        //    if (result != null)
        //    {
        //        return new ErrorDataResult<List<Image>>(GetDefaultImage(id).Data);
        //    }
        //    return new SuccessDataResult<List<Image>>(_imageDal.GetAll(i => i.Id == id));
        //}

        public IDataResult<List<Image>> GetImagesByUserId(int id)
        {
            //var result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return new ErrorDataResult<List<Image>>(GetDefaultImage(id).Data);
            //}
            return new SuccessDataResult<List<Image>>(_imageDal.GetAll(i => i.ImagesId == id));
        }

        public IResult Update(IFormFile file, Image image)
        {
            image.ImagePath = _fileHelper.Update(file, PathConstants.ImagesPath + image.ImagePath, PathConstants.ImagesPath);
            _imageDal.Update(image);
            return new SuccessResult(Messages.ImageUpdated);
        }
    }
}
