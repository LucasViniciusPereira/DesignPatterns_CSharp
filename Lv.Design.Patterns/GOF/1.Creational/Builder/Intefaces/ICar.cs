namespace Lv.Design.Patterns.GOF.Creational.Builder.Intefaces
{
    public interface ICar : IBuilderCar
    {
        int CarID { get; set; }
        string Name { get; set; }
    }
}
