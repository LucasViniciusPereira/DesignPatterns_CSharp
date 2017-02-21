using System.Collections.Generic;

namespace Lv.Design.Patterns.GOF.Behavioral.Observer
{
    public abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();

        public void Attach(Observer o)
        {
            observers.Add(o);
        }

        public void DeAttach(Observer o)
        {
            observers.Remove(o);
        }

        public void Notify()
        {
            foreach (var item in observers)
                item.Update();
        }
    }
}
