using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationJobsController : ControllerBase
    {
        IApplicationJobService _applicationJobService;

        public ApplicationJobsController(IApplicationJobService applicationJobService)
        {
            _applicationJobService = applicationJobService;
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            ;
            var result = _applicationJobService.GetByAppliedJobId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("getallbyemployerid")]
        public IActionResult GetAllByEmployerId(int employerId)
        {
            var result = _applicationJobService.GetAllByEmployerId(employerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(ApplicationJob applicationJob)

        {
            var result = _applicationJobService.Add(applicationJob);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


        [HttpPost("delete")]
        public IActionResult Delete(ApplicationJob applicationJob)
        {
            var result = _applicationJobService.Delete(applicationJob);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
