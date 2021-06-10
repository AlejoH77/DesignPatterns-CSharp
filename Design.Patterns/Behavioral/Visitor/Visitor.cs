using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Behavioral.Visitor
{
    public interface Visitor
    {
        double Visit(Mouse mouse);
        double Visit(KeyBoard keyBoard);
    }
}
