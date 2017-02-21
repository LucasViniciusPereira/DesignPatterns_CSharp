using Lv.Design.Patterns.GOF.Behavioral.Mediator.Interfaces;

namespace Lv.Design.Patterns.GOF.Behavioral.Mediator.Class
{
    public class User : Colleague
    {
        public User(IMediator m)
            : base(m)
        {
        }

        public override void Notify(string message)
        {
            System.Diagnostics.Debug.WriteLine("O Usuário recebeu a mensgem... " + message);
        }

        public override void Send(string message)
        {
            mediator.Send(message, this);
        }
    }
}
