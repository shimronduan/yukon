using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Service.Dtos
{
    public class PeriodDto
    {
        public string Day { get; set; }
        public string SubjectName { get; set; }
        public string TeacherName { get; set; }
        public int PeriodId { get; set; }
    }
}
