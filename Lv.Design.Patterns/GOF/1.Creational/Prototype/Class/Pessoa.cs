namespace Lv.Design.Patterns.GOF.Creational.Prototype.Class
{
    public abstract class Pessoa
    {
        public Pessoa(string nome, char sexo)
        {
            this.Nome = nome;
            this.Sexo = sexo;
        }

        public string Nome { get; set; }
        public char Sexo { get; set; }

        public abstract Pessoa Clone();
    }
}
