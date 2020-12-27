using NetCoreRepositoryAndUnitOfWorkPattern.Data.Repositories;
using NetCoreRepositoryAndUnitOfWorkPattern.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Service.Services
{
    public class PeriodService : IPeriodService
    {
        private readonly IPeriodRepository _periodRepository;
        public PeriodService(IPeriodRepository periodRepository)
        {
            _periodRepository = periodRepository;
        }
        public TimeTableDto GetAllPeriodsAsync()
        {
            var list = _periodRepository.GetAllPeriodWithSubjectAsync().ToList();
            var timetable = new TimeTableDto()
            {
                Period1 = new List<PeriodDto>(),
                Period2 = new List<PeriodDto>(),
                Period3 = new List<PeriodDto>(),
                Period4 = new List<PeriodDto>(),
                Period5 = new List<PeriodDto>(),
                Period6 = new List<PeriodDto>(),
                Period7 = new List<PeriodDto>(),
                Period8 = new List<PeriodDto>(),
            };
            for (int i = 0; i < list.Count; i++)
            {

                switch (list[i].PeriodNumber)
                {
                    case 1: timetable.Period1.Add(new PeriodDto { Day = getDayOfWeek(list[i].Day), SubjectName = list[i].Subject.Name, TeacherName = list[i].Subject.Teacher.Name, PeriodId = list[i].PeriodId }); break;
                    case 2: timetable.Period2.Add(new PeriodDto { Day = getDayOfWeek(list[i].Day), SubjectName = list[i].Subject.Name, TeacherName = list[i].Subject.Teacher.Name, PeriodId = list[i].PeriodId }); break;
                    case 3: timetable.Period3.Add(new PeriodDto { Day = getDayOfWeek(list[i].Day), SubjectName = list[i].Subject.Name, TeacherName = list[i].Subject.Teacher.Name, PeriodId = list[i].PeriodId }); break;
                    case 4: timetable.Period4.Add(new PeriodDto { Day = getDayOfWeek(list[i].Day), SubjectName = list[i].Subject.Name, TeacherName = list[i].Subject.Teacher.Name, PeriodId = list[i].PeriodId }); break;
                    case 5: timetable.Period5.Add(new PeriodDto { Day = getDayOfWeek(list[i].Day), SubjectName = list[i].Subject.Name, TeacherName = list[i].Subject.Teacher.Name, PeriodId = list[i].PeriodId }); break;
                    case 6: timetable.Period6.Add(new PeriodDto { Day = getDayOfWeek(list[i].Day), SubjectName = list[i].Subject.Name, TeacherName = list[i].Subject.Teacher.Name, PeriodId = list[i].PeriodId }); break;
                    case 7: timetable.Period7.Add(new PeriodDto { Day = getDayOfWeek(list[i].Day), SubjectName = list[i].Subject.Name, TeacherName = list[i].Subject.Teacher.Name, PeriodId = list[i].PeriodId }); break;
                    case 8: timetable.Period8.Add(new PeriodDto { Day = getDayOfWeek(list[i].Day), SubjectName = list[i].Subject.Name, TeacherName = list[i].Subject.Teacher.Name, PeriodId = list[i].PeriodId }); break;
                    default:
                        break;
                }

            }
            return timetable;
        }
        private string getDayOfWeek(int no)
        {
            switch (no)
            {
                case 1: return "Monday";
                case 2: return "Tuesday";
                case 3: return "Wednesday";
                case 4: return "Thursday";
                case 5: return "Friday";
                default:
                    return "";
            }
        }
    }
}
