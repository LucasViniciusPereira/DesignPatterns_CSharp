using System.Collections.Generic;

namespace Lv.Design.Patterns.GOF.Structural.Composite
{
    public class Form : ICompositeComponent
    {
        private List<ICompositeComponent> _children { get; set; }
        public string Name { get; set; }

        public Form(string _name)
        {
            this.Name = _name;
            _children = new List<ICompositeComponent>();
        }

        public void Add(ICompositeComponent c)
        {
            this._children.Add(c);
        }

        public void Remove(ICompositeComponent c)
        {
            this._children.Remove(c);
        }

        public void Display()
        {
            System.Diagnostics.Debug.WriteLine("Componente: " + this.GetType().Name + " - " + this.Name);
            foreach (var item in _children)
                item.Display();
        }
    }
}
