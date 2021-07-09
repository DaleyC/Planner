using Planner.Models;
using System;

namespace Planner.Services
{
    public interface IDayService
    {
        void CreateDay(DayDto day);
        void DeleteDay(DateTime date);
        DayDto GetDay(DateTime date);
        void UpdateDay(DayDto day);
    }
}