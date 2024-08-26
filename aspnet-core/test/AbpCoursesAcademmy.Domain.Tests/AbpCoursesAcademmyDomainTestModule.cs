using Volo.Abp.Modularity;

namespace AbpCoursesAcademmy;

[DependsOn(
    typeof(AbpCoursesAcademmyDomainModule),
    typeof(AbpCoursesAcademmyTestBaseModule)
)]
public class AbpCoursesAcademmyDomainTestModule : AbpModule
{

}
