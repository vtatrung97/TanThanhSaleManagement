using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Delta.SaleProject.EntityFrameworkCore
{
    public static class SaleProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SaleProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SaleProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}