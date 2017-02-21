namespace Lv.Design.Patterns.GOF.Behavioral.State
{
    public class Person
    {
        protected IPersonState state;

        public Person(IPersonState p)
        {
            this.state = p;
        }

        public void PlaySoccer()
        {
            System.Diagnostics.Debug.WriteLine("Jogando Bola");
            state.Running();
        }
        public void TargetShooting()
        {
            System.Diagnostics.Debug.WriteLine("Praticando Tiro ao Alvo");
            state.Stopped();
            state.Shooting();
        }
    }
}
