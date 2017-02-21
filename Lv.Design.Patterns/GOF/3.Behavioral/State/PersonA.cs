namespace Lv.Design.Patterns.GOF.Behavioral.State
{
    public class PersonA : IPersonState
    {
        public void Running()
        {
            System.Diagnostics.Debug.WriteLine("Personagem correndo");
        }

        public void Shooting()
        {
            System.Diagnostics.Debug.WriteLine("Personagem atirando");
        }

        public void Stopped()
        {
            System.Diagnostics.Debug.WriteLine("Personagem parado");
        }
    }
}
