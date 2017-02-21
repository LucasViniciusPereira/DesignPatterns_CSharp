using System;

namespace Lv.Design.Patterns.GOF.Behavioral.Iterator.Interfaces
{
    public interface IteratorSquad
    {
        void first();
        void next();
        bool isDone();
        Object currentItem();
    }
}
