namespace Lv.Design.Patterns.GOF.Behavioral.Observer
{
    public class MachineCredit : Subject
    {
        private bool _state = false;

        public bool State
        {
            get { return _state; }
            set { _state = value; }
        }

        public MachineCredit()
        {

        }

        public void Accept()
        {
            _state = true;
            System.Diagnostics.Debug.WriteLine("Passagem Liberada...");
            Notify();
        }
        public void Dennied()
        {
            _state = false;
            System.Diagnostics.Debug.WriteLine("Passagem Não autorizada...");
            Notify();
        }
    }
}
