using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Structural.Adapter
{
    /// <summary>
    /// The 'Target' class
    /// </summary>
    public abstract class Motor
    {
        abstract public void Encender();
        abstract public void Acelerar();
        abstract public void Apagar();
    }
}
