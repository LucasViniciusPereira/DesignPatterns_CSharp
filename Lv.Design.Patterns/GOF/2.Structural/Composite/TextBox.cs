namespace Lv.Design.Patterns.GOF.Structural.Composite
{
    public class TextBox : ICompositeComponent
    {
        public string Name { get; set; }

        public TextBox(string _name)
        {
            this.Name = _name;
        }

        public void Display()
        {
            System.Diagnostics.Debug.WriteLine("Componente: " + this.GetType().Name + " - " + this.Name);
        }
    }
}
