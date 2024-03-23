using SchoolAdnAPI.Services.Domain;
using Services.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Data
{
    public class Applicant : IApplicant
    {
        public Task<Task> addAchievementRecord(ApplicantAchievementRecord entity)
        {
            throw new NotImplementedException();
        }

        public Task<Task> completeApplicantAcademicData(ApplicantAcademicDatum entity)
        {
            throw new NotImplementedException();
        }

        public Task<Task> completeApplicantGeneralData(ApplicantDatum entity)
        {
            throw new NotImplementedException();
        }

        public Task<Task> completeApplicantPersonalData(ApplicantPersonalDatum entity)
        {
            throw new NotImplementedException();
        }

        public Task<Task> deleteAchievementRecord(int achievementID)
        {
            throw new NotImplementedException();
        }

        public Task<Task> finalizeData(int uid)
        {
            throw new NotImplementedException();
        }

        public Task<List<ScholarshipDatum>> generateScholarship()
        {
            throw new NotImplementedException();
        }

        public Task<ApplicantAcademicDatum> getAcademicData(string email)
        {
            throw new NotImplementedException();
        }

        public Task<List<ApplicantAchievementRecord>> getAchievementRecord(string email)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicantDatum> getApplicantData(string email)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicantPersonalDatum> getPersonalData(string email)
        {
            throw new NotImplementedException();
        }

        public Task<Task> login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<Task> register(UserDatum entity)
        {
            throw new NotImplementedException();
        }

        public Task<Task> updateApplicantAcademicData(ApplicantAcademicDatum entity)
        {
            throw new NotImplementedException();
        }

        public Task<Task> updateApplicantPersonalData(ApplicantPersonalDatum entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUserProfilePhoto(int userId, string photoPath)
        {
            throw new NotImplementedException();
        }
    }
}
