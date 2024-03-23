using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Data.Interfaces
{
    public interface IRank
    {
        Task<Task> GenerateRank();
        Task<Task> FinalizeRank();
    }
}
