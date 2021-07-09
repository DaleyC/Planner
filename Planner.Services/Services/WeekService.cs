using Planner.Models;

namespace Planner.Services
{
    public class WeekService : IWeekService
    {
        private readonly IWeekRepository _weekRepository;
        public WeekService(IWeekRepository weekRepository)
        {
            _weekRepository = weekRepository;
        }
        public void CreateWeek(WeekDto week)
        {
            Week weekEntity = WeekDtoToEntity(week);
            _weekRepository.CreateWeek(weekEntity);
        }

        private Week WeekDtoToEntity(WeekDto week)
        {
            var weekEntity = new Week()
            {
                Priorities = week.Priorities
            };
            return weekEntity;
        }
    }
}
