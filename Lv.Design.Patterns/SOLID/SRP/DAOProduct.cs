namespace Lv.Design.Patterns.SOLID.SRP
{
    public class DAOProduct : IDAOProduct
    {
        public void Create()
        {
            System.Diagnostics.Debug.WriteLine("Create product");
        }

        public void Delete()
        {
            System.Diagnostics.Debug.WriteLine("Delete product");
        }

        public void Read()
        {
            System.Diagnostics.Debug.WriteLine("Read product");
        }

        public void Upadate()
        {
            System.Diagnostics.Debug.WriteLine("Update product");
        }
    }
}
