namespace Lv.Design.Patterns.GOF.Structural.Adapter
{
    public class AdapterAPI : IAdapterAPI
    {
        private API _instance { get; set; }

        public AdapterAPI()
        {
            this._instance = new API();
        }

        public void RequestTargetAPI()
        {
            System.Diagnostics.Debug.WriteLine("Request Target API ");
            _instance.Request();
        }
    }
}
