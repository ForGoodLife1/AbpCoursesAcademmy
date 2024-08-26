using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpCoursesAcademmy;

[Dependency(ReplaceServices = true)]
public class AbpCoursesAcademmyBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpCoursesAcademmy";
}
