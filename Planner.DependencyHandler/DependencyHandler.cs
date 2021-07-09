using Autofac;
using Planner.DataAccessLayer;
using Planner.Services;

namespace Planner.DependencyHandler
{
    public static class DependencyHandler
    {

        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DayRepository>().As<IDayRepository>();
            builder.RegisterType<MonthRepository>().As<IMonthRepository>();
            builder.RegisterType<WeekRepository>().As<IWeekRepository>();

            builder.RegisterType<DayService>().As<IDayService>();
            builder.RegisterType<WeekService>().As<IWeekService>();
            builder.RegisterType<MonthService>().As<IMonthService>();

            return builder.Build();
        }
    }
}
