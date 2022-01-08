using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //add delete getallbyemployerid GetByFavoriteJobId
    public class FavoriteJobsController : ControllerBase
    {
        IFavoriteJobService _favoritejobService; //naming conventeion

        public FavoriteJobsController(IFavoriteJobService favoriteJobService)
        {
            _favoritejobService = favoriteJobService;
        }

        //[HttpGet("getall")]
        //public IActionResult GetAll()
        //{
        //    //dependency chain
        //    //IEmployerService employerService = new EmployerManager(new EfEmployerDal());
        //    var result = _favoritejobService.Get
        //    if (result.Success)
        //    {
        //        return Ok(result.Data);
        //    }
        //    return BadRequest(result.Message);
        //}

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {;
            var result = _favoritejobService.GetByFavoriteJobId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getbyjobid")]
        public IActionResult GetByJobId(int id)
        {
            var result = _favoritejobService.GetByJobId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("getallbyemployerid")]
        public IActionResult GetAllByEmployerId(int employerId)
        {
            var result = _favoritejobService.GetAllByEmployerId(employerId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(FavoriteJob favoriteJob)
        {
            var result = _favoritejobService.Add(favoriteJob);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("delete")]
        public IActionResult Delete(FavoriteJob favoriteJob)
        {
            var result = _favoritejobService.Delete(favoriteJob);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
