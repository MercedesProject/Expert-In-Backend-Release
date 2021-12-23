using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        //Loosely coupled
        //Ioc Container -- Inversion of Controller (Startup.cs)
        IJobService _jobService; //naming conventeion

        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //dependency chain
            //IEmployerService employerService = new EmployerManager(new EfEmployerDal());
            var result = _jobService.GetJobDetails();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            //dependency chain
            //IEmployerService employerService = new EmployerManager(new EfEmployerDal());
            var result = _jobService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Job job)
        {
            var result = _jobService.Add(job);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
