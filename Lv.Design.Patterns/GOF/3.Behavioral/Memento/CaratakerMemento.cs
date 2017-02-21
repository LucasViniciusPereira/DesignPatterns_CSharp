using System.Collections.Generic;
using System.Linq;

namespace Lv.Design.Patterns.GOF.Behavioral.Memento
{
    public class CaratakerMemento
    {
        public List<Memento> state;

        public CaratakerMemento()
        {
            state = new List<Memento>();
        }

        public void addText(string text)
        {
            state.Add(new Memento(text));
        }

        public Memento getLast()
        {
            if (state.Count == 0)
                return new Memento("Vazio");
            return state.Last();
        }
    }
}
