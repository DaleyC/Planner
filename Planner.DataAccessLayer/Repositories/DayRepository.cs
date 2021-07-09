using Planner.Models;
using System;
using Planner.Services;

namespace Planner.DataAccessLayer
{
    public class DayRepository : IDayRepository
    {
        public Day GetDay(DateTime date)
        {
            return new Day()
            {
                Date = date
            };
        }
        public void UpdateDay(Day day)
        {

        }

        public void CreateDay(Day day)
        {

        }

        public void DeleteDay(DateTime date)
        {
            
        }
    }
}
