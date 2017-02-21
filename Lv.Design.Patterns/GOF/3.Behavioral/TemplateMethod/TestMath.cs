namespace Lv.Design.Patterns.GOF.Behavioral.TemplateMethod
{
    public class TestMath : IRevise
    {
        public override void Refine()
        {
            System.Diagnostics.Debug.WriteLine("Prova de Matematica processada");
        }
    }
}
