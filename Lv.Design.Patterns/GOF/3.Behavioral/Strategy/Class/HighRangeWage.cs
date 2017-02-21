using Lv.Design.Patterns.GOF.Behavioral.Strategy.Interfaces;

namespace Lv.Design.Patterns.GOF.Behavioral.Strategy.Class
{
    public class HighRangeWage : IOfficial
    {
        public void CalcSalary()
        {
            System.Diagnostics.Debug.WriteLine("Calculando faixa salarial ALTA.");
        }
    }
}
