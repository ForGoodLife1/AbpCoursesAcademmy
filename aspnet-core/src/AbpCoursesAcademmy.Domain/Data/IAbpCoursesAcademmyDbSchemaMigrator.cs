using System.Threading.Tasks;

namespace AbpCoursesAcademmy.Data;

public interface IAbpCoursesAcademmyDbSchemaMigrator
{
    Task MigrateAsync();
}
