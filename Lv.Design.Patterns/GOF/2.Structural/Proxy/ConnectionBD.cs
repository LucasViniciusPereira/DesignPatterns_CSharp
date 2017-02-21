namespace Lv.Design.Patterns.GOF.Structural.Proxy
{
    public class ConnectionBD : IConnectionBD
    {
        private int qtdUser { get; set; } = 20;
        private int qtdUserConnected { get; set; } = 10;

        public void getCountUsers()
        {
            System.Diagnostics.Debug.WriteLine("Tem: " + qtdUser + " usuários.");
        }

        public void getCountUsersConnected()
        {
            System.Diagnostics.Debug.WriteLine("Tem: " + qtdUserConnected + " usuários connectados.");
        }
    }
}
