using System;
using System.Collections.Generic;

namespace Lv.Design.Patterns.EXTRAS.Event
{
    public class Highway
    {
        public void Invoke(string name, int velocity)
        {
            System.Diagnostics.Debug.WriteLine($"O carro: {name} está com a velocidade de {velocity}KM");
        }

        public Highway()
        {
            Car.OnEvent += Invoke;
        }
    }
}