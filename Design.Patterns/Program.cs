using Design.Patterns.Clients.Behavioral;
using Design.Patterns.Clients.Structural;
using System;

namespace Design.Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //AdapterClient adapterClient = new AdapterClient();
            //adapterClient.Ejecutar();

            //FacadeClient facadeClient = new FacadeClient();
            //facadeClient.Ejecutar();

            //MediatorClient mediatorClient = new MediatorClient();
            //mediatorClient.Ejecutar();
            //mediatorClient.Ejecutar2();

            VisitorClient visitorClient = new VisitorClient();
            visitorClient.RunDesignPatter();
        }
    }
}
