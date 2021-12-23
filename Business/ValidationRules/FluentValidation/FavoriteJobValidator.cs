using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class FavoriteJobValidator : AbstractValidator<FavoriteJob>
    {
        //favoritejob business rule buraya yazılacak.
        public FavoriteJobValidator()
        {
            //RuleFor(e => e.EmployerName).NotEmpty();
            //RuleFor(e => e.EmployerSurname).MinimumLength(2);
            //RuleFor(e => e.EmployerSurname).NotEmpty();
            //RuleFor(e => e.EmployerPhoneNumber).GreaterThan(0);
            //RuleFor(e => e.EmployerName).Must(StartWithA).WithMessage("Employerlar A harfi ile baslamali");
        }
        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
