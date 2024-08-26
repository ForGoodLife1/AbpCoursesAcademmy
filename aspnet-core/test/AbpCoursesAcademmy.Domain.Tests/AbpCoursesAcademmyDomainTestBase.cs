using Volo.Abp.Modularity;

namespace AbpCoursesAcademmy;

/* Inherit from this class for your domain layer tests. */
public abstract class AbpCoursesAcademmyDomainTestBase<TStartupModule> : AbpCoursesAcademmyTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
