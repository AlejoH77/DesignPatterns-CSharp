using Design.Patterns.Behavioral.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Clients.Behavioral
{
    class MediatorClient
    {
        public void Ejecutar()
        {
            ConcreteColleague1 component1 = new ConcreteColleague1();
            ConcreteColleague2 component2 = new ConcreteColleague2();
            
            _ = new ConcreteMediator(component1, component2);

            Console.WriteLine("El cliente ejecuta la operación A");
            component1.EjecutarA();

            Console.WriteLine();

            Console.WriteLine("El cliente ejecuta la operación D");
            component2.EjecutarD();
        }

        public void Ejecutar2()
        {
            ISalondeChat salonDeChat = new SalonDeChat();

            Usuario u1 = new Usuario(salonDeChat);
            u1.Nombre = "Juan";
            salonDeChat.Registrar(u1);

            Usuario u2 = new Usuario(salonDeChat);
            u2.Nombre = "Pepe";
            salonDeChat.Registrar(u2);

            Usuario u3 = new Usuario(salonDeChat);
            u3.Nombre = "Martin";
            salonDeChat.Registrar(u3);

            u1.Envia("Pepe", "Hola, como estas?");
            u2.Envia("Juan", "Bien y usted?");
            u3.Envia("Pepe", "La buena Pepe");
        }
    }
}
