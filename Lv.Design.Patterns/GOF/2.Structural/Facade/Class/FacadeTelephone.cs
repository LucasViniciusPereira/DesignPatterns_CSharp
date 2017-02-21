using Lv.Design.Patterns.GOF.Structural.Facade.Interfaces;

namespace Lv.Design.Patterns.GOF.Structural.Facade.Class
{
    public class FacadeTelephone
    {
        protected ITelephone telephone;

        public FacadeTelephone(ITelephone parameter)
        {
            this.telephone = parameter;
        }

        public void InitializeTelephone()
        {
            var component = new IphoneComponent(telephone);

            telephone.Initialize();
            component.Initialize();
            component.Aplications();
            component.Camera();
            component.phonebook();
            component.Memory();
        }
    }
}
