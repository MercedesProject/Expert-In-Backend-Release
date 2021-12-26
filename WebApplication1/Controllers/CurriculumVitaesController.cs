using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        public IActionResult Add(IFormFile file, [FromForm] CurriculumVitae curriculumVitae)
        {
            var result = _curriculumVitaeService.Add(file, curriculumVitae);
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
    }
}
