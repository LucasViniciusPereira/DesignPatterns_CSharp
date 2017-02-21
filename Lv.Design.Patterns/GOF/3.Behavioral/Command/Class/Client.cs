using Lv.Design.Patterns.GOF.Behavioral.Command.Interfaces;

namespace Lv.Design.Patterns.GOF.Behavioral.Command.Class
{
    public class Client
    {
        private ICommand command;

        public Client(ICommand c)
        {
            this.command = c;
        }

        public void Validate()
        {
            System.Diagnostics.Debug.WriteLine("Executando a validação CLIENTE");
            command.Execute();
        }
    }
}
