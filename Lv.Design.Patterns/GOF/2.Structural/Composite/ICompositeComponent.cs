namespace Lv.Design.Patterns.GOF.Structural.Composite
{
    public interface ICompositeComponent
    {
        string Name { get; set; }
        void Display();
    }
}
