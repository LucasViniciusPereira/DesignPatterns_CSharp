namespace Lv.Design.Patterns.GOF.Creational.Singleton.Class
{
    public class ConnectionBD
    {
        private static Connection Connection;

        public ConnectionBD(Connection cnn)
        {
            if (Connection == null)
                Connection = cnn;
        }

        public static Connection Instance()
        {
            return Connection;
        }

        public void OpenConnection()
        {
            Connection.Open();
        }
    }
}
