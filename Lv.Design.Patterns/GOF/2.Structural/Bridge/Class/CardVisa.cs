using Lv.Design.Patterns.GOF.Structural.Bridge.Interfaces;

namespace Lv.Design.Patterns.GOF.Structural.Bridge.Class
{
    public class CardVisa : ICard
    {
        public void Transaction()
        {
            System.Diagnostics.Debug.WriteLine("Transação do cartao VISA");
        }
    }
}
