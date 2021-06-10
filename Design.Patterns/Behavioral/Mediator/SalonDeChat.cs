using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Behavioral.Mediator
{
    public class SalonDeChat : ISalondeChat
    {
        private readonly Dictionary<string, Usuario> participantes = new Dictionary<string, Usuario>();

        public void Enviar(string de, string a, string msg)
        {
            if(participantes.TryGetValue(de, out Usuario usuarioOrigen) && participantes.TryGetValue(a, out Usuario usuarioDestino))
            {
                usuarioDestino.Recibe(de, msg);
            }
        }

        public void Registrar(Usuario usuario)
        {
            participantes.Add(usuario.Nombre, usuario);
        }
    }
}
