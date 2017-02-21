namespace Lv.Design.Patterns.GOF.Structural.Proxy
{
    public class ProxyConnectionBD : IConnectionBD
    {
        private string User { get; set; }
        private string Password { get; set; }
        protected IConnectionBD _instance;

        public ProxyConnectionBD(string _user, string _pass)
        {
            this.User = _user;
            this.Password = _pass;
            this._instance = new ConnectionBD();
        }

        public void getCountUsers()
        {
            if (HasPermission())
                this._instance.getCountUsers();
            else
                System.Diagnostics.Debug.WriteLine("Usuário sem permissão para acessar o Banco de Dados.");
        }

        public void getCountUsersConnected()
        {
            if (HasPermission())
                this._instance.getCountUsersConnected();
            else
                System.Diagnostics.Debug.WriteLine("Usuário sem permissão para acessar o Banco de Dados.");
        }

        //Verify permission access
        private bool HasPermission()
        {
            return User == "ADMIN" && Password == "123456";
        }
    }
}
