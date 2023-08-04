using Elsa.Persistence.EntityFramework.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ELSADemo.Data
{
    public class PostgreSqlElsaContextFactory : IDesignTimeDbContextFactory<ElsaContext>
    {
        public ElsaContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddCommandLine(args)
                .Build();

            var dbContextBuilder = new DbContextOptionsBuilder();
            var connectionString = configuration.GetConnectionString("Elsa");

            dbContextBuilder.UseNpgsql(connectionString, Postgre => Postgre.MigrationsAssembly(typeof(Elsa.Persistence.EntityFramework.PostgreSql.PostgreSqlElsaContextFactory).Assembly.FullName));

            return new ElsaContext(dbContextBuilder.Options);
            ///dotnet ef database update -- ConnectionStrings:Elsa="Server=127.0.0.1;Port=5432;Database=elsa;User Id=postgres;Password=admin;"
        }
    }
}
