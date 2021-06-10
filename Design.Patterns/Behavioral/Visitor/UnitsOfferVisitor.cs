using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Behavioral.Visitor
{
    public class UnitsOfferVisitor : Visitor
    {
        public double Visit(Mouse mouse)
        {
            if(mouse.Amount > 4)
            {
                return mouse.Amount + 2;
            }
            else
            {
                return mouse.Amount;
            }
        }

        public double Visit(KeyBoard keyBoard)
        {
            if(keyBoard.Amount > 10)
            {
                return keyBoard.Amount + 1;
            }
            else
            {
                return keyBoard.Amount;
            }
        }
    }
}
