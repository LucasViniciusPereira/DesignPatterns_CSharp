using Lv.Design.Patterns.GOF.Structural.Decorator.Interfaces;

namespace Lv.Design.Patterns.GOF.Structural.Decorator.Class
{
    public class DecoratorADO : IDecoratorRepository
    {
        public DecoratorADO(IRepository repo)
            : base(repo)
        {
        }

        public override void CommitADO()
        {
            System.Diagnostics.Debug.WriteLine("Commit com net Framework ADO");
        }
    }
}
