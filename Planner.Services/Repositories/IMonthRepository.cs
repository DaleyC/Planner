using Planner.Models;

namespace Planner.Services
{
    public interface IMonthRepository
    {
        void CreateMonth(Month month);
        void DeleteMonth(int monthId);
        void UpdateMonth(Month month);
    }
}