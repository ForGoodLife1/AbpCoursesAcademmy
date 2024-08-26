using AbpCoursesAcademmy.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpCoursesAcademmy.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpCoursesAcademmyEntityFrameworkCoreModule),
    typeof(AbpCoursesAcademmyApplicationContractsModule)
    )]
public class AbpCoursesAcademmyDbMigratorModule : AbpModule
{
}
