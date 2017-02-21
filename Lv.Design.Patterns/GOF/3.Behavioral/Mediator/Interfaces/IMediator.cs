namespace Lv.Design.Patterns.GOF.Behavioral.Mediator.Interfaces
{
    public interface IMediator
    {
        void Send(string message, Colleague colleague);
    }
}
