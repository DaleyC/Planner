using Planner.Models;

namespace Planner.Services
{
    public class MonthService : IMonthService
    {
        private readonly IMonthRepository _monthRepository;
        public MonthService(IMonthRepository monthRepository)
        {
            _monthRepository = monthRepository;
        }

        public void CreateMonth(MonthDto month)
        {
            Month monthEntity = MonthDtoToEntity(month);
            _monthRepository.CreateMonth(monthEntity);
        }

        private Month MonthDtoToEntity(MonthDto month)
        {
            var monthEntity = new Month()
            {
                Goals = month.Goals
            };

            return monthEntity;
        }
    }
}
