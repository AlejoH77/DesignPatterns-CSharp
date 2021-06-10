using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Behavioral.Mediator
{
    public class ConcreteColleague2: Colleague
    {
        public void EjecutarC()
        {
            Console.WriteLine("El componente 2 realiza C.");

            this._mediator.Notify(this, "C");
        }

        public void EjecutarD()
        {
            Console.WriteLine("El componente 2 realiza D.");

            this._mediator.Notify(this, "D");
        }
    }
}
