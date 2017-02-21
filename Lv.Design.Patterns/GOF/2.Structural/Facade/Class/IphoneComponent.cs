using Lv.Design.Patterns.GOF.Structural.Facade.Interfaces;

namespace Lv.Design.Patterns.GOF.Structural.Facade.Class
{
    public class IphoneComponent : ITelephoneComponent
    {
        private ITelephone telephone;

        public IphoneComponent(ITelephone telephone)
        {
            this.telephone = telephone;
        }

        public void Aplications()
        {
            System.Diagnostics.Debug.WriteLine("Inicializando Aplicativos do " + telephone.GetType().Name);
        }

        public void Camera()
        {
            System.Diagnostics.Debug.WriteLine("Inicializando serviço de camera do " + telephone.GetType().Name);
        }

        public void Initialize()
        {
            System.Diagnostics.Debug.WriteLine("Inicializando sistema operacional do " + telephone.GetType().Name);
        }

        public void Memory()
        {
            System.Diagnostics.Debug.WriteLine("Inicializando serviço de memoria do " + telephone.GetType().Name);
        }

        public void phonebook()
        {
            System.Diagnostics.Debug.WriteLine("Inicializando serviço de agenda do " + telephone.GetType().Name);
        }

        public void TurnOff()
        {
            System.Diagnostics.Debug.WriteLine("Destruir serviços do " + telephone.GetType().Name);
        }
    }
}
