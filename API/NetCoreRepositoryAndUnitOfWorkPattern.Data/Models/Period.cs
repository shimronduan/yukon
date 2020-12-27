using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Data.Models
{
    public class Period
    {
        public int PeriodId { get; set; }
        public Subject Subject { get; set; }
        public int Day { get; set; }
        public int PeriodNumber { get; set; }

    }
}
