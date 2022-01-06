using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CurriculumVitaesController : ControllerBase 
    {
        ICurriculumVitaeService _curriculumVitaeService;

        public CurriculumVitaesController(ICurriculumVitaeService curriculumVitaeService)
        {
            _curriculumVitaeService = curriculumVitaeService;
        }

        [HttpPost("add")]
        public IActionResult Add(IFormFile file, int userId)
        {
            var cv = new CurriculumVitae();
            cv.UserId = userId;
            var result = _curriculumVitaeService.Add(file, cv);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(CurriculumVitae curriculumVitae)
        {
            var result = _curriculumVitaeService.Delete(curriculumVitae);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getimagesbyuserid")]
        public IActionResult GetImagesByUserId(int id)
        {
            var result = _curriculumVitaeService.GetImagesByUserId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpPost("download")]
        //public async Task<IActionResult> DownloadAsync()
        //{
        //    var path = @"C:\Users\Tuğba Öğünçmert\Documents\GitHub\Expert-In-Backend-Release\WebApplication1\wwwroot\Uploads\CurriculumVitaes\Tugba_Oguncmert_CV.pdf";
        //    var memory = new MemoryStream();
        //    using (var stream = new FileStream(path, FileMode.Open))
        //    {
        //        await stream.CopyToAsync(memory);
        //    }
        //    memory.Position = 0;
        //    var ext = Path.GetExtension(path).ToLowerInvariant();
        //    return File(memory, GetMimeTypes()[ext], Path.GetFileName(path));
        //}

        [HttpGet("download")]
        public async Task<IActionResult> DownloadAsync(string curriculumVitaePath)
        {
            //var path = @"C:\Users\Tuğba Öğünçmert\Documents\GitHub\Expert-In-Backend-Release\WebApplication1\wwwroot\Uploads\CurriculumVitaes\Tugba_Oguncmert_CV.pdf";
            var memory = new MemoryStream();
            using (var stream = new FileStream(curriculumVitaePath, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            var ext = Path.GetExtension(curriculumVitaePath).ToLowerInvariant();
            return File(memory, GetMimeTypes()[ext], Path.GetFileName(curriculumVitaePath));
        }

        private Dictionary<string,string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".pdf","application/pdf" },
                {".png","image/png" }
            };
        }
    }
}
