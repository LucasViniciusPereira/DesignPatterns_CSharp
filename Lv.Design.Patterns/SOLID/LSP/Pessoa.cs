namespace Lv.Design.Patterns.SOLID.LSP
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void Eat();
    }
}