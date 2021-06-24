namespace TestJustForTest.Persistence
{
    using Microsoft.Extensions.Logging;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using TestJustForTest.Entities;

    public class DatabaseContextSeed
    {
        public static async Task SeedAsync(DatabaseContext dbContext, ILogger<DatabaseContextSeed> logger)
        {
            if (!dbContext.Pieces.Any())
            {
                dbContext.Pieces.AddRange(GetPreconfiguredPieces());
                await dbContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", typeof(DatabaseContext).Name);
            }
        }

        private static IEnumerable<Piece> GetPreconfiguredPieces()
        {
            return new List<Piece>
            {
              
            };
        }
    }
}
