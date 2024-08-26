using Volo.Abp.Modularity;

namespace AbpCoursesAcademmy;

[DependsOn(
    typeof(AbpCoursesAcademmyApplicationModule),
    typeof(AbpCoursesAcademmyDomainTestModule)
)]
public class AbpCoursesAcademmyApplicationTestModule : AbpModule
{

}
