using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv.Design.Patterns.GOF.Creational.AbstractFactory
{
    public class AbstractFactory
    {

    }

    public enum eCategoryCar
    {
        Undefined = 0,
        Sedan = 1,
        Picape = 2
    }

    public interface ICar {
        int CarID { get; set; }
        string Name { get; set; }
        eCategoryCar Category { get; set; }
    }

    public interface IMontadora {
        void ListCarSedan();
        void ListCarPicape();
    }

    public class Fiat {

        public List<ICar> Cars = null;

        public Fiat()
        {
            Cars = new List<ICar>();

            Cars.Add(new Palio { CarID = 1, Category = eCategoryCar.Sedan, Name = "Palio Simples" });
            Cars.Add(new Palio { CarID = 2, Category = eCategoryCar.Sedan, Name = "Palio Completo" });
            Cars.Add(new Palio { CarID = 3, Category = eCategoryCar.Picape, Name = "Strada Adventure"});
        }
    }

    public class Palio : ICar
    {
        public int CarID { get; set; }
        public string Name { get; set; }
        public eCategoryCar Category { get; set; }
    }
    public class Strada : ICar
    {
        public int CarID { get; set; }
        public string Name { get; set; }
        public eCategoryCar Category { get; set; }
    }

    public class Volkswagen {
        public List<ICar> Cars { get; set; }
    }
}
