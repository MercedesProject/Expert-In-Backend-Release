using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DraftJobsController : ControllerBase
    {
        //Loosely coupled
        //Ioc Container -- Inversion of Controller (Startup.cs)
        IDraftJobService _DraftJobService; //naming conventeion

        public DraftJobsController(IDraftJobService DraftJobService)
        {
            _DraftJobService = DraftJobService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //dependency chain
            //IEmployerService employerService = new EmployerManager(new EfEmployerDal());
            var result = _DraftJobService.GetJobDetails();
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
            var result = _DraftJobService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(DraftJob DraftJob)
        {
            var result = _DraftJobService.Add(DraftJob);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpDelete("delete")]
        public IActionResult Delete(DraftJob DraftJob)
        {
            var result = _DraftJobService.Delete(DraftJob);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}