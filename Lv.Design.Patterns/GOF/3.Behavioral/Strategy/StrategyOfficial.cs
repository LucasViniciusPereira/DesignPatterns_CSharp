using Lv.Design.Patterns.GOF.Behavioral.Strategy.Class;

namespace Lv.Design.Patterns.GOF.Behavioral.Strategy
{
    public class StrategyOfficial
    {
        public void CalcSalary(decimal salary)
        {
            if (salary <= 1500M)
                new LowRangeWage().CalcSalary();
            else if (salary <= 4000M)
                new MediumRangeWage().CalcSalary();
            else
                new HighRangeWage().CalcSalary();
        }
    }
}