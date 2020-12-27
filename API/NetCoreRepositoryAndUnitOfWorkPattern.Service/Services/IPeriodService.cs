using NetCoreRepositoryAndUnitOfWorkPattern.Service.Dtos;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Service.Services
{
    public interface IPeriodService
    {
        TimeTableDto GetAllPeriodsAsync();
    }
}
