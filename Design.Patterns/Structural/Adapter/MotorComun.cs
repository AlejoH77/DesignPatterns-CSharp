using System;

namespace Design.Patterns.Structural.Adapter
{
    public class MotorComun : Motor
    {
        public MotorComun()
        {
            Console.WriteLine("Creando motor común");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerando motor común");
        }

        public override void Apagar()
        {
            Console.WriteLine("Apagando motor común");
        }

        public override void Encender()
        {
            Console.WriteLine("Encendiendo motor común");
        }
    }
}
