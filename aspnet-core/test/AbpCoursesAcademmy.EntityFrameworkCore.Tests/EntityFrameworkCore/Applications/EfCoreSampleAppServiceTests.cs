using AbpCoursesAcademmy.Samples;
using Xunit;

namespace AbpCoursesAcademmy.EntityFrameworkCore.Applications;

[Collection(AbpCoursesAcademmyTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AbpCoursesAcademmyEntityFrameworkCoreTestModule>
{

}
