namespace Lv.Design.Patterns.GOF.Behavioral.TemplateMethod
{
    public abstract class IRevise
    {
        public abstract void Refine();

        public void process()
        {
            System.Diagnostics.Debug.WriteLine("Processando prova");
            Refine();
        }
    }
}
