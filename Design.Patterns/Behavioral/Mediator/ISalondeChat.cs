using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Behavioral.Mediator
{
    public interface ISalondeChat
    {
        void Registrar(Usuario usuario);
        void Enviar(string de, string a, string msg);
    }
}
