using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Data.Repositories
{
    public interface IPeriodRepository : IRepository<Period>
    {
        Task<Period> GetPeriodByIdAsync(int id);

        //Task<List<Period>> GetAllPeriodAsync();
        IQueryable<Period> GetAllPeriodWithSubjectAsync();
    }
}
