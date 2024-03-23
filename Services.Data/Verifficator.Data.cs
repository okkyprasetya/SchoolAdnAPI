using SchoolAdnAPI.Services.Domain;
using Services.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Data
{
    public class Verifficator : IVerificator
    {
        public Task<Task> addVerificator(VerificatorDatum entity)
        {
            throw new NotImplementedException();
        }

        public Task<Task> deleteVerificator(int UserID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<VerificatorDatum>> getAllVerificator()
        {
            throw new NotImplementedException();
        }

        public Task<VerificatorDatum> getVerificator(int verID)
        {
            throw new NotImplementedException();
        }

        public Task<Task> login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<Task> updateVerificator(VerificatorDatum entity)
        {
            throw new NotImplementedException();
        }
    }
}
