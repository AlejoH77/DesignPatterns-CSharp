using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Structural.Adapter
{
    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    public class MotorElectrico
    {
        private bool Conectado;

        public MotorElectrico()
        {
            Console.WriteLine("Creando motor eléctrico");
            Conectado = false;
        }

        public void Conectar()
        {
            Console.WriteLine("Conectando Motor eléctrico");
            Conectado = true;
        }

        public void Activar()
        {
            if (Conectado)
            {
                Console.WriteLine("Está conectado, activando el motor eléctrico");
            }
            else
            {
                Console.WriteLine("No se puede activar porque no está conectado el motor eléctrico");
            }
        }

        public void MoverMasRapido()
        {
            if (Conectado)
            {
                Console.WriteLine("Moviendo más rápido, aumentando el voltaje del motor eléctrico");
            }
            else
            {
                Console.WriteLine("No se puede mover más rápido porque no está conectado el motor eléctrico");
            }
        }

        public void Detener()
        {
            if (Conectado)
            {
                Console.WriteLine("Deteniendo motor eléctrico");
            }
            else
            {
                Console.WriteLine("No se puede detener el motor eléctrico porque no está conectado");
            }
        }

        public void Desconectar()
        {
            Console.WriteLine("Desconectando motor eléctrico");
            Conectado = false;
        }
    }
}
