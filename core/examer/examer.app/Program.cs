using System;
using examer.entities.DTO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.DependencyInjection;
using examer.efcore;
namespace examer.app
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerFactory MyLoggerFactory = new LoggerFactory(new[]{new ConsoleLoggerProvider((category, level)
            => true, true)});

            IServiceCollection collection = new ServiceCollection();

            collection.AddDbContext<ExamerContext>(t => t.UseLoggerFactory(MyLoggerFactory)
            .UseMySql("Data Source=localhost;database=Examer;user=root;password=2793751"), ServiceLifetime.Scoped)
            .AddDbContext<DbContext, ExamerContext>();
            var service = collection.BuildServiceProvider();

            var ctx = service.GetService<ExamerContext>();
            var List = ctx.Set<UserEntity>().GroupBy(t => t.Create_Date).Select(t => new { t.Key, CNT = t.Count() }).ToList();

            Console.ReadLine();

        }
    }
}
