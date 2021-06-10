using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Behavioral.Mediator
{
    public interface IUsuarioChat
    {
        public void Recibe(string de, string msg);
        public void Envia(string a, string msg);
    }
}
