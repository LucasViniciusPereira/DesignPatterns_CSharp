using System;
using Lv.Design.Patterns.GOF.Creational.Builder.Intefaces;

namespace Lv.Design.Patterns.GOF.Creational.Builder
{
    public class BuilderPalio : ICar
    {
        public int CarID { get; set; }
        public string Name { get { return Name; } set { Name = "Palio"; }}

        public void BuilderChassis()
        {
            Console.WriteLine("Palio - Chassis Create.");
        }

        public void BuilderMotor()
        {
            Console.WriteLine("Palio - Motor Create.");
        }

        public void BuilderWheels()
        {
            Console.WriteLine("Palio - Wheels Create.");
        }
    }
}
