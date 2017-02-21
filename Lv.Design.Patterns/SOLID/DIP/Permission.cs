namespace Lv.Design.Patterns.SOLID.DIP
{
    public class Permission
    {
        private IPermission _permission;

        public Permission(IPermission p)
        {
            this._permission = p;
        }

        public void CheckPermission() {
            _permission.IsValid();
        }
    }
}
