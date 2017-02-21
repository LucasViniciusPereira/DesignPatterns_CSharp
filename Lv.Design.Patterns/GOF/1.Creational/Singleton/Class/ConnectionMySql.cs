using System;

namespace Lv.Design.Patterns.GOF.Creational.Singleton.Class
{
    public class ConnectionMySql : Connection
    {
        public ConnectionMySql(string cnn)
            : base(cnn)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Abrindo conexão com MYSQL " + strCNN);
        }
    }
}
