namespace Lv.Design.Patterns.SOLID.OCP
{
    public class Division : IOperation
    {
        public void Calculate(int numb1, int numb2)
        {
            System.Diagnostics.Debug.WriteLine("Calcular divisão: " + numb1 + "/" + numb2);
        }
    }
}
