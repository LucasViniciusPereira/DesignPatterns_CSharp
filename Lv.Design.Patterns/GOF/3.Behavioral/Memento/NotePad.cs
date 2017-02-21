namespace Lv.Design.Patterns.GOF.Behavioral.Memento
{
    public class NotePad
    {
        protected string _text = "";
        CaratakerMemento caretaker;

        public NotePad()
        {
            caretaker = new CaratakerMemento();
        }

        public void wrtieText(string newText)
        {
            caretaker.addText(_text);
            _text += newText;

            System.Diagnostics.Debug.WriteLine(_text);
        }

        public void undoText()
        {
            _text = caretaker.getLast().getText();

            System.Diagnostics.Debug.WriteLine(_text);
        }
    }
}
