namespace Lv.Design.Patterns.GOF.Behavioral.Memento
{
    public class Memento
    {
        protected string Text;

        public Memento(string text)
        {
            this.Text = text;
        }

        public string getText()
        {
            return Text;
        }
    }
}
