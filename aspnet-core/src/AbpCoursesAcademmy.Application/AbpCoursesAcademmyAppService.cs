using System;
using System.Collections.Generic;
using System.Text;
using AbpCoursesAcademmy.Localization;
using Volo.Abp.Application.Services;

namespace AbpCoursesAcademmy;

/* Inherit your application services from this class.
 */
public abstract class AbpCoursesAcademmyAppService : ApplicationService
{
    protected AbpCoursesAcademmyAppService()
    {
        LocalizationResource = typeof(AbpCoursesAcademmyResource);
    }
}
