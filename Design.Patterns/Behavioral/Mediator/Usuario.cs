using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Behavioral.Mediator
{
    public class Usuario : IUsuarioChat
    {
        public string Nombre { get; set; }
        private readonly ISalondeChat _salon;

        public Usuario(ISalondeChat salon)
        {
            _salon = salon;
        }

        public void Envia(string a, string msg)
        {
            _salon.Enviar(Nombre, a, msg);
        }

        public void Recibe(string de, string msg)
        {
            Console.WriteLine("{0} el usuario {1} te dice {2}", Nombre, de, msg);
        }
    }
}
