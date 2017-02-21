namespace Lv.Design.Patterns.GOF.Creational.Prototype.Class
{
    public class Filho : Pessoa
    {
        public Filho(string nome, char sexo)
            : base(nome, sexo)
        {
        }

        public override Pessoa Clone()
        {
            return (Filho)this.MemberwiseClone();
        }
    }
}
