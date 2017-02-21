namespace Lv.Design.Patterns.GOF.Behavioral.TemplateMethod
{
    public class TestPortuguese : IRevise
    {
        public override void Refine()
        {
            System.Diagnostics.Debug.WriteLine("Prova de Portugues processada");
        }
    }
}
