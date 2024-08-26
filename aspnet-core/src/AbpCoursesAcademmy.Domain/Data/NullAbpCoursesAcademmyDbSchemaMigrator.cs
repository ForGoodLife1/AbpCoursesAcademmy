using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpCoursesAcademmy.Data;

/* This is used if database provider does't define
 * IAbpCoursesAcademmyDbSchemaMigrator implementation.
 */
public class NullAbpCoursesAcademmyDbSchemaMigrator : IAbpCoursesAcademmyDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
