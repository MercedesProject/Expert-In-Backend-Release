using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string EmployerAdded = "Employer eklendi";
        public static string EmployerSurnameInvalid = "Employer soyadı 3ten kısa olamaz.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string EmployersListed = "Employers listed";
        public static string EmployerUpdated = "Employers updated";

        public static string EmployerNameALreadyExists = "Bu isimde bir employer var";
        public static string ProductCountOfCategoryError = "ProductCountOfCategoryError";

        public static string UserTypeLimitExceded = "bu user tipine başka ekleme yapılamaz";

        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string JobsListed = "iş ilanları listelendi.";
        public static string JobAdded = "ilan eklendi";

        public static string FavoriteJobAdded = "ilan favoriye alındı";
        public static string FavoriteJobDeleted = "ilan favoriden kaldırıldı";

        public static string CompanyUpdated = "şirket güncellendi";
        public static string CompaniesListed = "şirket listelendi";
        public static string CompanyAdded = "Şirket eklendi";

        public static string ImageAdd = "Image Added";
        public static string ImageAddErrorMessage = "The image was not  added";
        public static string ImageUpdated = "Image updated";

        public static string SaveSkillAdded = "Employer Skill ekledi";

        public static string ProjectAdded = "Proje ekledi";
        public static string ProjectDelete = "proje silindi";
        public static string ProjectUpdate = "Proje updated";

        public static string EducationUpdated = "Education güncellendi";
        public static string EducationDeleted = "Education silindi";
        public static string EducationAdded = "Education ekledi";

        public static string ExperienceAdded = "Deneyim ekledi";
        public static string ExperienceDeleted = "Deneyim silindi";
        public static string ExperienceUpdated = "Deneyim güncellendi"; 

        public static string ApplicationReceived = "Başvurunuz alındı.";
        public static string ApplicationCancel = "Başvurunuz iptal edildi.";
        public static string DuplicateApplication = "Bu ilana zaten başvurdunuz.";

        public static string CurriculumVitaeAdd = "Cv yüklendi";

        public static string DraftJobAdded = "İlan Taslağı Oluşturuldu."; 
        public static string DraftJobsListed = "İlan Taslağı Listelendi.";
        public static string DraftJobsUpdated = "İlan Taslağı Güncellendi.";

        public static string CompanyDeleted = "şirket silindi";
        public static string JobUpdated = "job updated";
        public static string JobDeleted = "job deleted"; //todo tugba
        internal static string FavColumnChanged = "job tablelındaki favStatus columnı upd.";
    }
}
