using Lv.Design.Patterns.GOF.Structural.Bridge.Interfaces;

namespace Lv.Design.Patterns.GOF.Structural.Bridge.Class
{
    public class DebitCard : IPayment
    {
        public DebitCard(ICard card)
            : base(card)
        {

        }

        public override void RequestTransaction(decimal value, string user)
        {
            System.Diagnostics.Debug.WriteLine($"DEBITO --- Valor: {value}, Usuario: {user}");
            _card.Transaction();
        }
    }
}
