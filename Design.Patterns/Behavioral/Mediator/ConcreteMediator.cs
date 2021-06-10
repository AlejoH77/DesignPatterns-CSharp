using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Behavioral.Mediator
{
    public class ConcreteMediator : IMediator
    {
        private readonly ConcreteColleague1 _component1;

        private readonly ConcreteColleague2 _component2;

        public ConcreteMediator(ConcreteColleague1 component1, ConcreteColleague2 component2)
        {
            this._component1 = component1;
            this._component1.SetMediator(this);
            this._component2 = component2;
            this._component2.SetMediator(this);
        }

        public void Notify(object sender, string ev)
        {
            if (ev == "A")
            {
                ReactOnA();
            }
            if (ev == "D")
            {
                ReactOnD();
            }
            /*
            if(sender.GetType() == _component1.GetType())
            {

            }
            */
        }

        private void ReactOnA()
        {
            Console.WriteLine("El mediador reacciona en A y activa las siguientes operaciones:");
            this._component2.EjecutarC();
        }

        private void ReactOnD()
        {
            Console.WriteLine("El mediador reacciona en D y activa las siguientes operaciones:");
            this._component1.EjecutarB();
            this._component2.EjecutarC();
        }
    }
}
