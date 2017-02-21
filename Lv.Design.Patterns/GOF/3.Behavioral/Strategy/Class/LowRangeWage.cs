using Lv.Design.Patterns.GOF.Behavioral.Strategy.Interfaces;

namespace Lv.Design.Patterns.GOF.Behavioral.Strategy.Class
{
    public class LowRangeWage : IOfficial
    {
        public void CalcSalary()
        {
            System.Diagnostics.Debug.WriteLine("Calculando faixa salarial BAIXA.");
        }
    }
}
