using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpCoursesAcademmy.Data;
using Volo.Abp.DependencyInjection;

namespace AbpCoursesAcademmy.EntityFrameworkCore;

public class EntityFrameworkCoreAbpCoursesAcademmyDbSchemaMigrator
    : IAbpCoursesAcademmyDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpCoursesAcademmyDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the AbpCoursesAcademmyDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpCoursesAcademmyDbContext>()
            .Database
            .MigrateAsync();
    }
}
