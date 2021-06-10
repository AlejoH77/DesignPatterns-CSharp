using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Behavioral.Mediator
{
    public class ConcreteColleague1: Colleague
    {
        public void EjecutarA()
        {
            Console.WriteLine("El componente 1 realiza A.");

            this._mediator.Notify(this, "A");
        }

        public void EjecutarB()
        {
            Console.WriteLine("El componente 1 realiza B.");

            this._mediator.Notify(this, "B");
        }
    }
}
