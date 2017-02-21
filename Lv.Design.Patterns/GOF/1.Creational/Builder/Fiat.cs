using Lv.Design.Patterns.GOF.Creational.Builder.Intefaces;

namespace Lv.Design.Patterns.GOF.Creational.Builder
{
    public class Fiat : IMontadora
    {
        public ICar CreateCar()
        {
            return new BuilderPalio();
        }
    }
}
