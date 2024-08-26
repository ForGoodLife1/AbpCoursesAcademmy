using AbpCoursesAcademmy.Samples;
using Xunit;

namespace AbpCoursesAcademmy.EntityFrameworkCore.Domains;

[Collection(AbpCoursesAcademmyTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AbpCoursesAcademmyEntityFrameworkCoreTestModule>
{

}
