namespace Lv.Design.Patterns.GOF.Behavioral.ChainOfResponsibility
{
    public abstract class IValidade
    {
        protected IValidade _next;

        public void setNext(IValidade setNext)
        {
            this._next = setNext;
        }

        public abstract bool Validate(string name, string password);
    }
}
