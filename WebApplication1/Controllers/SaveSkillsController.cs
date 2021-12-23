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
    public class SaveSkillsController : ControllerBase
    {
        ISaveSkillService _saveSkillService;
        public SaveSkillsController(ISaveSkillService saveSkillService)
        {
            _saveSkillService = saveSkillService;
        }

        [HttpPost("add")]
        public IActionResult Add(SaveSkill SaveSkill)
        {
            var result = _saveSkillService.Add(SaveSkill);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyemployerid")]
        public IActionResult GetById(int id)
        {
            var result = _saveSkillService.GetAllByEmployerId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _saveSkillService.GetSaveSkillDetails();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

    }

}
