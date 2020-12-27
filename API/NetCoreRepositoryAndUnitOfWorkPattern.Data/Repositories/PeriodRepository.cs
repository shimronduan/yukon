using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Data.Repositories
{
    public class PeriodRepository : Repository<Period>, IPeriodRepository
    {
        public PeriodRepository(RepositoryPatternDemoContext repositoryPatternDemoContext) : base(repositoryPatternDemoContext)
        {
        }

        public IQueryable<Period> GetAllPeriodWithSubjectAsync()
        {
            return GetAll().Include(m=>m.Subject).ThenInclude(m=>m.Teacher);
        }

        public async Task<Period> GetPeriodByIdAsync(int id)
        {
            return await GetAll().FirstOrDefaultAsync(x => x.PeriodId == id);
        }
    }
}
