using Lv.Design.Patterns.GOF.Structural.Decorator.Interfaces;

namespace Lv.Design.Patterns.GOF.Structural.Decorator.Class
{
    public class EntityFramework : IRepository
    {
        public void commit()
        {
            System.Diagnostics.Debug.WriteLine("Commit com entity Framework");
        }
    }
}
