using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Data.Interfaces
{
    public interface IBills
    {
        Task<Task> AssignBills();
        Task<Task> ClearBills();
    }
}
