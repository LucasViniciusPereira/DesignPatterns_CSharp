using Lv.Design.Patterns.GOF.Creational.Builder.Intefaces;

namespace Lv.Design.Patterns.GOF.Creational.Builder
{
    public class BuilderCar
    {
        public void builder(IBuilderCar builder){
            builder.BuilderChassis();
            builder.BuilderMotor();
            builder.BuilderWheels();
        }
    }
}
