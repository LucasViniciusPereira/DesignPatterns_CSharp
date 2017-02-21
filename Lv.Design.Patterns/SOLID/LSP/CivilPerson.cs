namespace Lv.Design.Patterns.SOLID.LSP
{
    public class CivilPerson : Person
    {
        public override void Eat()
        {
            System.Diagnostics.Debug.WriteLine("Pessoa Jurídica.");
        }
    }
}
