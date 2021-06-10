using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Behavioral.Visitor
{
    public class DiscountVisitor : Visitor
    {
        public double Visit(Mouse mouse)
        {
            return mouse.Price * 1;
        }

        public double Visit(KeyBoard keyBoard)
        {
            return keyBoard.Price * 0.7;
        }
    }
}
