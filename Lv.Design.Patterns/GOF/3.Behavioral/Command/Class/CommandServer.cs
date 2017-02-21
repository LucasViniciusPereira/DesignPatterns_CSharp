using Lv.Design.Patterns.GOF.Behavioral.Command.Interfaces;

namespace Lv.Design.Patterns.GOF.Behavioral.Command.Class
{
    public class CommandServer : ICommand
    {
        private Server _server;

        public CommandServer(Server s)
        {
            this._server = s;
        }

        public void Execute()
        {
            _server.ValidateServer();
        }
    }
}
