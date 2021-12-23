using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private IAuthService _authService;
        private IEmployerService _employerService;
        private ICompanyService _companyService;

        public AuthController(IAuthService authService, IEmployerService employerService, ICompanyService companyService)
        {
            _authService = authService;
            _employerService = employerService;
            _companyService = companyService;
        }

        [HttpPost("login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Message);
            }

            var result = _authService.CreateAccessToken(userToLogin.Data);
            if (result.Success)
            {
                string userMail = userForLoginDto.Email;
                return Ok(userToLogin.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authService.UserExists(userForRegisterDto.Email);
            if (!userExists.Success)
            {
                return BadRequest(userExists.Message);
            }

            var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.Password);
            var result = _authService.CreateAccessToken(registerResult.Data);
            if (result.Success)
            {
                if (userForRegisterDto.UserTypesID == 1)
                {
                    //Employer employer = new Employer(userForRegisterDto.UserTypesID,1, userForRegisterDto.Name, userForRegisterDto.LastName,
                    //    "title","ist",0,"mail","web","desc",0,"");
                    Employer employer = new Employer();
                    employer.UserTypeId = 1;
                    employer.EmployerName = userForRegisterDto.Name;
                    employer.EmployerSurname = userForRegisterDto.LastName;
                    employer.EmployerEMail = userForRegisterDto.Email;
                    employer.EmployerPhoneNumber = 0;
                    //employer.EmployerTitle = "ogrenci";
                    //employer.EmployerLocation = "ist";
                    //employer.EmployerWebSite = "bombabomba.com";
                    //employer.EmployerAboutMe = "helloworld";
                    //employer.EmployerPhoto = null;
                    //employer.EmployerResume = null;
                    _employerService.Add(employer);
                }
                if (userForRegisterDto.UserTypesID == 2)
                {
                    Company company = new Company();
                    company.UserTypeId = userForRegisterDto.UserTypesID;
                    company.CompanyName = userForRegisterDto.Name;
                    company.SectorId = 2;
                    _companyService.Add(company);
                }

                return Ok(result.Data);
            }
            
            return BadRequest(result.Message);
        }
    }
}