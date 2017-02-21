namespace Lv.Design.Patterns.SOLID.OCP
{
    public class Sum : IOperation
    {
        public void Calculate(int numb1, int numb2)
        {
            System.Diagnostics.Debug.WriteLine("Calcular soma: " + numb1 + "+" + numb2);
        }
    }
}
