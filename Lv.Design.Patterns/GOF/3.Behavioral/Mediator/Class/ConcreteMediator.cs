using Lv.Design.Patterns.GOF.Behavioral.Mediator.Interfaces;

namespace Lv.Design.Patterns.GOF.Behavioral.Mediator.Class
{
    public class ConcreteMediator : IMediator
    {
        public User user { private get; set; }
        public Support support { private get; set; }

        public void Instance(User p1, Support p2)
        {
            user = p1;
            support = p2;
        }

        public void Send(string message, Colleague colleague)
        {
            if (colleague == user)
                support.Send(message);
            else
                user.Send(message);
        }
    }
}
