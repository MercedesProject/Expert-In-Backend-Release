using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IImageService
    {
        IResult Add(IFormFile file, Image image);
        IResult Update(IFormFile file, Image image);
        IResult Delete(Image image);
        IDataResult<List<Image>> GetAll();


        //IDataResult<List<Image>> GetImagesByEmployerId(int id);
        //IDataResult<List<Image>> GetImagesByCompanyId(int id);
        IDataResult<List<Image>> GetImagesByUserId(int id);
    }
}