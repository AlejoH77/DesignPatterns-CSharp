using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Behavioral.Visitor
{
    public class Mouse : Product
    {
        public Mouse(double price, int amount) : base(price, amount)
        {
            
        }

        public override double Accept(Visitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
