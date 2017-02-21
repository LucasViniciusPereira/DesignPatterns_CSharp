namespace Lv.Design.Patterns.SOLID.DIP
{
    public class UserA : IPermission
    {
        public void IsValid()
        {
            System.Diagnostics.Debug.WriteLine("Chek permission User A");
        }
    }
}
