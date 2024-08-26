using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpCoursesAcademmy.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AbpCoursesAcademmyDbContextFactory : IDesignTimeDbContextFactory<AbpCoursesAcademmyDbContext>
{
    public AbpCoursesAcademmyDbContext CreateDbContext(string[] args)
    {
        AbpCoursesAcademmyEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AbpCoursesAcademmyDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new AbpCoursesAcademmyDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AbpCoursesAcademmy.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
