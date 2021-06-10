using Design.Patterns.Structural.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Clients.Structural
{
    public class AdapterClient
    {
        private Motor motor;

        public void Ejecutar()
        {
            string opcion;
            do
            {
                Console.WriteLine("----------------------- \n¿Qué motor desea usar? \n----------------------- \n 1. Motor común \n 2. Motor económico \n 3. Motor eléctrico");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        motor = new MotorComun();
                        UsarMotor();
                        break;
                    case "2":
                        motor = new MotorEconomico();
                        UsarMotor();
                        break;
                    case "3":
                        motor = new MotorElectricoAdapter();
                        UsarMotor();
                        break;
                    case "4":
                        Console.WriteLine("Finalizando programa");
                        break;
                    default:
                        Console.WriteLine("Opción ingresada NO es válida");
                        break;
                }
            } while (!opcion.Equals("4"));
        }

        private void UsarMotor()
        {
            motor.Encender();
            motor.Acelerar();
            motor.Apagar();
        }
    }
}
