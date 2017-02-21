namespace Lv.Design.Patterns.GOF.Behavioral.State
{
    public interface IPersonState
    {
        void Running();
        void Stopped();
        void Shooting();
    }
}
