namespace Lv.Design.Patterns.GOF.Creational.Singleton.Class
{
    public abstract class Connection
    {
        protected string strCNN { get; set; }

        public Connection(string cnn)
        {
            this.strCNN = cnn;
        }

        public abstract void Open();
    }
}
