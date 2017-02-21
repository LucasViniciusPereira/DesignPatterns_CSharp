namespace Lv.Design.Patterns.GOF.Structural.Facade.Interfaces
{
    public interface ITelephoneComponent : ITelephone
    {
        void Aplications();
        void Camera();
        void phonebook();
        void Memory();
    }
}