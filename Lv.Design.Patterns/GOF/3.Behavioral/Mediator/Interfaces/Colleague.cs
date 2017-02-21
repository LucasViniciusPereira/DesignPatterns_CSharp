namespace Lv.Design.Patterns.GOF.Behavioral.Mediator.Interfaces
{
    public abstract class Colleague
    {
        protected IMediator mediator;

        public Colleague(IMediator m)
        {
            this.mediator = m;
        }

        public abstract void Send(string message);
        public abstract void Notify(string message);
    }
}
