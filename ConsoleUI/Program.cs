using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployerTest();
            //EmployerOtherTest();
            //UserTypeTest();
        }

        private static void EmployerTest()
        {
            EmployerManager employerManager = new EmployerManager(new EfEmployerDal(), new UserTypeManager(new EfUserTypeDal()));

            foreach (var employer in employerManager.GetAll().Data)
            {
                Console.WriteLine(employer.EmployerName + " " + employer.EmployerSurname);

            }
        }
        private static void EmployerOtherTest()
        {
            EmployerManager employerManager = new EmployerManager(new EfEmployerDal(), new UserTypeManager(new EfUserTypeDal()));

            var result = employerManager.GetEmployerDetails();
            
            if(result.Success == true)
            {
                foreach (var employer in result.Data)
                {
                    Console.WriteLine(employer.EmployerName + " " + employer.UserTypeCategory);

                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        private static void UserTypeTest()
        {
            UserTypeManager userTypeManager = new UserTypeManager(new EfUserTypeDal());

            foreach (var userType in userTypeManager.GetAll().Data)
            {
                Console.WriteLine(userType.UserTypeCategory);

            }
        }
    }
}