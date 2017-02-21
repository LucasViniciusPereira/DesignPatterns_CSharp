namespace Lv.Design.Patterns.SOLID.LSP
{
    public class PhysicalPerson : Person
    {
        public override void Eat()
        {
            System.Diagnostics.Debug.WriteLine("Pessoa Fisica.");
        }
    }
}
