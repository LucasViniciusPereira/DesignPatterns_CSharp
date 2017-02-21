using System;

namespace Lv.Design.Patterns.EXTRAS.Event
{
    public class Car
    {
        protected string _name { get; set; }
        protected int _velocity { get; set; }

        public Car(string name, int velocity)
        {
            _name = name;
            _velocity = velocity;
        }

        //Event
        //Action<T0..16> retorno void (parâmetros opcionais)
        //Func<T1..T16, out TResult> retornam um tipo TResult (Object) (parâmetros opcionais)
        //Predicate<T> retornam true ou false.
        public static event Action<string, int> OnEvent;

        public void SpeedUP()
        {
            if (_velocity > 60 && OnEvent != null)
            {
                System.Diagnostics.Debug.WriteLine("Chamando evento...");
                OnEvent(_name, _velocity);
            }
            else
                System.Diagnostics.Debug.WriteLine("Velocidade abaixo de 60KM, não chama evento.");
        }
    }
}
