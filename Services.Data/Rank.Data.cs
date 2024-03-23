using Services.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Data
{
    internal class Rank : IRank
    {
        public Task<Task> FinalizeRank()
        {
            throw new NotImplementedException();
        }

        public Task<Task> GenerateRank()
        {
            throw new NotImplementedException();
        }
    }
}
