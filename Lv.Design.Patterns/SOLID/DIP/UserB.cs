namespace Lv.Design.Patterns.SOLID.DIP
{
    public class UserB : IPermission
    {
        public void IsValid()
        {
            System.Diagnostics.Debug.WriteLine("Chek permission User B");
        }
    }
}
