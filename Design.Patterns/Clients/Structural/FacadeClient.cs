using Design.Patterns.Structural.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Clients.Structural
{
    public class FacadeClient
    {
        public void Ejecutar()
        {
            Facade facade = new Facade();
            string resultado = facade.Operation();
            Console.WriteLine(resultado);
        }
        
    }
}
