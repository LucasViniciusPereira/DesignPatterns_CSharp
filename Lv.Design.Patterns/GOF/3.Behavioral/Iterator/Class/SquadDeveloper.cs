using Lv.Design.Patterns.GOF.Behavioral.Iterator.Interfaces;
using System.Collections.Generic;

namespace Lv.Design.Patterns.GOF.Behavioral.Iterator.Class
{
    public class SquadDeveloper : Squad, IAggregateSquad
    {
        public List<Squad> squads { get; set; }

        public SquadDeveloper()
        {
            squads = new List<Squad>();
            squads.Add(new Squad { Name = "Ciclano 1" });
            squads.Add(new Squad { Name = "Ciclano 2" });
            squads.Add(new Squad { Name = "Ciclano 3" });
            squads.Add(new Squad { Name = "Ciclano 4" });
        }

        public IteratorSquad CreateIterator()
        {
            return new IteratorListSquad(squads);
        }
    }
}
