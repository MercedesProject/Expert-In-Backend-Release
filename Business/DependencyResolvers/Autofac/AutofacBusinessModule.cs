using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        //proje ayağa kalktığında çalışacak
        protected override void Load(ContainerBuilder builder)
        {
            //service istenirse manager ver
            builder.RegisterType<EmployerManager>().As<IEmployerService>().SingleInstance();
            builder.RegisterType<EfEmployerDal>().As<IEmployerDal>().SingleInstance();

            builder.RegisterType<UserTypeManager>().As<IUserTypeService>().SingleInstance();
            builder.RegisterType<EfUserTypeDal>().As<IUserTypeDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            builder.RegisterType<JobManager>().As<IJobService>().SingleInstance();
            builder.RegisterType<EfJobDal>().As<IJobDal>().SingleInstance();

            builder.RegisterType<FavoriteJobManager>().As<IFavoriteJobService>().SingleInstance();
            builder.RegisterType<EfFavoriteJobDal>().As<IFavoriteJobDal>().SingleInstance();


            builder.RegisterType<CompanyManager>().As<ICompanyService>().SingleInstance();
            builder.RegisterType<EfCompanyDal>().As<ICompanyDal>().SingleInstance();

            builder.RegisterType<ImageManager>().As<IImageService>().SingleInstance();
            builder.RegisterType<EfImageDal>().As<IImageDal>().SingleInstance();

            builder.RegisterType<SaveSkillManager>().As<ISaveSkillService>().SingleInstance();
            builder.RegisterType<EfSaveSkillDal>().As<ISaveSkillDal>().SingleInstance();

            builder.RegisterType<EducationManager>().As<IEducationService>().SingleInstance();
            builder.RegisterType<EfEducationDal>().As<IEducationDal>().SingleInstance();

            builder.RegisterType<ExperienceManager>().As<IExperienceService>().SingleInstance();
            builder.RegisterType<EfExperienceDal>().As<IExperienceDal>().SingleInstance();

            builder.RegisterType<ProjectManager>().As<IProjectService>().SingleInstance();
            builder.RegisterType<EfProjectDal>().As<IProjectDal>().SingleInstance();


            builder.RegisterType<FileHelperManager>().As<IFileHelper>().SingleInstance();
            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>();




            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();


        }
    }
}
