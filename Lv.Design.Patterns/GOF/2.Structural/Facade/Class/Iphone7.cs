using Lv.Design.Patterns.GOF.Structural.Facade.Interfaces;

namespace Lv.Design.Patterns.GOF.Structural.Facade.Class
{
    public class Iphone7 : ITelephone
    {
        public void Initialize()
        {
            System.Diagnostics.Debug.WriteLine("Inicializando Telefone");
        }

        public void TurnOff()
        {
            System.Diagnostics.Debug.WriteLine("Desligando Telefone");
        }
    }
}
