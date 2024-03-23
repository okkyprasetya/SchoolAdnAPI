using SchoolAdnAPI.Services.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Data.Interfaces
{
    public interface IVerificator
    {
        Task<Task> login(string email, string password);
        Task<Task> addVerificator(VerificatorDatum entity);
        Task<IEnumerable<VerificatorDatum>> getAllVerificator();
        Task<VerificatorDatum> getVerificator(int verID);
        Task<Task> deleteVerificator(int UserID);
        Task<Task> updateVerificator(VerificatorDatum entity);
    }
}
