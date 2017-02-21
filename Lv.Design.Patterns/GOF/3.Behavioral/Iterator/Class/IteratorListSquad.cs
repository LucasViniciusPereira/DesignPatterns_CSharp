using Lv.Design.Patterns.GOF.Behavioral.Iterator.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Lv.Design.Patterns.GOF.Behavioral.Iterator.Class
{
    public class IteratorListSquad : IteratorSquad
    {
        private List<Squad> squads;
        public IteratorListSquad(List<Squad> squads)
        {
            this.squads = squads;
        }
        private int current = 0;

        public object currentItem()
        {
            if (isDone())
                current = squads.Count - 1;
            else if (current < 0)
                current = 0;

            return squads[current];
        }

        public void first()
        {
            current = 0;
            squads.First();

            System.Diagnostics.Debug.WriteLine("Primeiro é: " + squads.First().Name);
        }

        public bool isDone()
        {
            return current >= squads.Count ? true : false;
        }

        public void next()
        {
            current++;
            System.Diagnostics.Debug.WriteLine("O item é: " + squads[current].Name);
        }
    }
}
