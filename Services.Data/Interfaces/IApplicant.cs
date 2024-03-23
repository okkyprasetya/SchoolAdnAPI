using SchoolAdnAPI.Services.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Data.Interfaces
{
    public interface IApplicant
    {
        Task<Task> login (string email, string password);
        Task<Task> register (UserDatum entity);
        Task<Task> finalizeData(int uid);
        Task<Task> completeApplicantGeneralData(ApplicantDatum entity);
        Task<Task> completeApplicantPersonalData(ApplicantPersonalDatum entity);
        Task<Task> updateApplicantPersonalData(ApplicantPersonalDatum entity);
        Task<Task> completeApplicantAcademicData(ApplicantAcademicDatum entity);
        Task<Task> updateApplicantAcademicData(ApplicantAcademicDatum entity);
        Task<Task> addAchievementRecord(ApplicantAchievementRecord entity);
        Task<Task> deleteAchievementRecord(int achievementID);
        Task<bool> UpdateUserProfilePhoto(int userId, string photoPath);
        Task<List<ScholarshipDatum>> generateScholarship();
        Task<ApplicantDatum> getApplicantData(string email);
        Task<ApplicantAcademicDatum> getAcademicData(string email);
        Task<List<ApplicantAchievementRecord>> getAchievementRecord(string email);
        Task<ApplicantPersonalDatum> getPersonalData(string email);
    }
}
