namespace Lv.Design.Patterns.GOF.Creational.Prototype.Class
{
    public class Pai : Pessoa
    {
        public Pai(string nome, char sexo)
            : base(nome, sexo)
        {
        }

        public override Pessoa Clone()
        {
            return (Pai)this.MemberwiseClone();
        }
    }
}
