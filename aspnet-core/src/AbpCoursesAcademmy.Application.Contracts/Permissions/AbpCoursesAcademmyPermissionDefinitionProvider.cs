using AbpCoursesAcademmy.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpCoursesAcademmy.Permissions;

public class AbpCoursesAcademmyPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpCoursesAcademmyPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpCoursesAcademmyPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpCoursesAcademmyResource>(name);
    }
}
