using Planner.Models;
using System;

namespace Planner.Services
{
    public interface IDayRepository
    {
        Day GetDay(DateTime date);
        void CreateDay(Day day);
        void DeleteDay(DateTime date);
        void UpdateDay(Day day);
    }
}
