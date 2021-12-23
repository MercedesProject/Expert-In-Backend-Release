using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployersController : ControllerBase
    {
        //Loosely coupled
        //Ioc Container -- Inversion of Controller (Startup.cs)
        IEmployerService _employerService; //naming conventeion

        public EmployersController(IEmployerService employerService)
        {
            _employerService = employerService;
        }

        ////[HttpGet]
        ////public string Deneme()
        ////{
        ////    return "ıs it working";
        ////}

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //dependency chain
            //IEmployerService employerService = new EmployerManager(new EfEmployerDal());
            var result = _employerService.GetAll();
            if(result.Success)
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
            var result = _employerService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Employer employer)
        {
            var result = _employerService.Add(employer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("update")]
        public IActionResult Update(Employer employer)
        {
            var result = _employerService.Update(employer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
