using Lv.Design.Patterns.GOF.Behavioral.Mediator.Interfaces;

namespace Lv.Design.Patterns.GOF.Behavioral.Mediator.Class
{
    public class Support : Colleague
    {
        public Support(IMediator m)
            : base(m)
        {
        }

        public override void Notify(string message)
        {
            System.Diagnostics.Debug.WriteLine("O Suporte recebeu a mensgem... " + message);
        }

        public override void Send(string message)
        {
            mediator.Send(message, this);
        }
    }
}
