using ConsoleApp88.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
namespace ConsoleApp88.Models
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            using AppDbContext dbContext = new AppDbContext();

            var PendingMigration = await dbContext.Database.GetPendingMigrationsAsync();
            if (PendingMigration.Any())
                await dbContext.Database.MigrateAsync();












        }
    }
}
