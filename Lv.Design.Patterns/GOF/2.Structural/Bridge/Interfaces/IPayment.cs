namespace Lv.Design.Patterns.GOF.Structural.Bridge.Interfaces
{
    public abstract class IPayment
    {
        protected ICard _card;

        protected IPayment(ICard card)
        {
            _card = card;
        }

        public abstract void RequestTransaction(decimal value, string user);
    }
}