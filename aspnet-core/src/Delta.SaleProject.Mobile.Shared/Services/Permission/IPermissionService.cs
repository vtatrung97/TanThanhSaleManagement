namespace Delta.SaleProject.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}