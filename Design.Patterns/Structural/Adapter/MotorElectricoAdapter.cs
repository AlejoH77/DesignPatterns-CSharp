using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Structural.Adapter
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    public class MotorElectricoAdapter : Motor
    {
        private readonly MotorElectrico _motorElectrico;

        public MotorElectricoAdapter()
        {
            Console.WriteLine("Creando adaptador de motor eléctrico");
            _motorElectrico = new MotorElectrico();
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerando el adaptador de motor eléctrico");
            _motorElectrico.MoverMasRapido();
        }

        public override void Apagar()
        {
            Console.WriteLine("Apagando el adaptador de motor eléctrico");
            _motorElectrico.Detener();
            _motorElectrico.Desconectar();
        }

        public override void Encender()
        {
            Console.WriteLine("Encendiendo el adaptador de motor eléctrico");
            _motorElectrico.Conectar();
            _motorElectrico.Activar();
        }
    }
}
