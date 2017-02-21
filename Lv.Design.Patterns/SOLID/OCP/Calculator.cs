namespace Lv.Design.Patterns.SOLID.OCP
{
    public class Calculator
    {
        public void Operation(IOperation op, int numb1, int numb2)
        {
            System.Diagnostics.Debug.WriteLine("Calculando...");
            op.Calculate(numb1, numb2);
        }
    }
}
