namespace Lv.Design.Patterns.GOF.Behavioral.Observer
{
    public class RouletteBus : Observer
    {
        private bool _state;

        MachineCredit machine;

        public RouletteBus(MachineCredit m)
        {
            this.machine = m;
        }

        public void Start()
        {
            if (_state)
                System.Diagnostics.Debug.WriteLine("Roleta destravada...");
            else
                System.Diagnostics.Debug.WriteLine("Erro ao destravar roleta!!!");
        }

        public void Stop()
        {
            if (_state)
                System.Diagnostics.Debug.WriteLine("Roleta travada...");
            else
                System.Diagnostics.Debug.WriteLine("Erro ao travar a roleta");
        }

        public override void Update()
        {
            _state = machine.State;
        }
    }
}
