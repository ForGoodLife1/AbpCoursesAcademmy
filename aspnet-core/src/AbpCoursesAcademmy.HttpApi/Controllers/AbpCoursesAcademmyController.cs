using AbpCoursesAcademmy.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpCoursesAcademmy.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpCoursesAcademmyController : AbpControllerBase
{
    protected AbpCoursesAcademmyController()
    {
        LocalizationResource = typeof(AbpCoursesAcademmyResource);
    }
}
