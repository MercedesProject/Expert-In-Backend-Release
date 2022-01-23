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
        //IApplicationJobService _applicationJobService; //naming conventeion
        //IFavoriteJobService _favoriteJobService; //naming conventeion
        //IDraftJobService _draftJobService; //naming conventeion

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

        [HttpGet("getallbycompanyid")]
        public IActionResult GetAllByCompanyId(int id)
        {
            //dependency chain
            //IEmployerService employerService = new EmployerManager(new EfEmployerDal());
            var result = _jobService.GetAllByCompanyId(id);
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

        [HttpDelete("delete")]
        public IActionResult Delete(Job job)
        {
            var result = _jobService.Delete(job);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("update")]
        public IActionResult Update(Job job)
        {
            var result = _jobService.Update(job);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("updateafterfav")]
        public IActionResult UpdateAfterFav(Job job)
        {
            var result = _jobService.ChangeFavStatusAfterFav(job);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("updateafterunfav")]
        public IActionResult UpdateAfterUnfav(Job job)
        {
            var result = _jobService.ChangeFavStatusAfterUnfav(job);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("counter")]
        public IActionResult Counter()
        {
            int result = _jobService.Counter();
            if (result > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
