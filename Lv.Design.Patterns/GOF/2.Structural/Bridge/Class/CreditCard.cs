using Lv.Design.Patterns.GOF.Structural.Bridge.Interfaces;

namespace Lv.Design.Patterns.GOF.Structural.Bridge.Class
{
    public class CreditCard : IPayment
    {
        public CreditCard(ICard card)
            : base(card)
        {

        }

        public override void RequestTransaction(decimal value, string user)
        {
            System.Diagnostics.Debug.WriteLine($"CREDITO --- Valor: {value}, Usuario: {user}");
            _card.Transaction();
        }
    }

}
