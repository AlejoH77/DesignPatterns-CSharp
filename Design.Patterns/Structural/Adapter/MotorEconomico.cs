using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Structural.Adapter
{
    public class MotorEconomico:Motor
    {
        public MotorEconomico()
        {
            Console.WriteLine("Creando motor económico");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerando motor económico");
        }

        public override void Apagar()
        {
            Console.WriteLine("Apagando motor económico");
        }

        public override void Encender()
        {
            Console.WriteLine("Encendiendo motor económico");
        }
    }
}
