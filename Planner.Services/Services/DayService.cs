using Planner.Models;
using System;

namespace Planner.Services
{
    public class DayService : IDayService
    {
        private IDayRepository _dayRepository;
        public DayService(IDayRepository dayRepository)
        {
            _dayRepository = dayRepository;
        }
        public DayDto GetDay(DateTime date)
        {
            Day dayEntity = _dayRepository.GetDay(date);
            return dayEntityToDto(dayEntity);
        }
        public void UpdateDay(DayDto day)
        {
            Day dayEntity = dayDtoToEntity(day);
            _dayRepository.UpdateDay(dayEntity);
        }

        public void CreateDay(DayDto day)
        {
            Day dayEntity = dayDtoToEntity(day);
            _dayRepository.CreateDay(dayEntity);
        }

        public void DeleteDay(DateTime date)
        {
            _dayRepository.DeleteDay(date);
        }

        private DayDto dayEntityToDto(Day day)
        {
            var dayDto = new DayDto()
            {
                Date = day.Date
            };
            return dayDto;
        }

        private Day dayDtoToEntity(DayDto day)
        {
            var dayEntity = new Day()
            {
                Date = day.Date
            };
            return dayEntity;
        }
    }
}
