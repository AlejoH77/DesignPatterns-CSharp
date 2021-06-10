using Design.Patterns.Behavioral.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Clients.Behavioral
{
    public class VisitorClient
    {
        public void RunDesignPatter()
        {
            Product keyBoard = new KeyBoard(150, 2);
            Product mouse = new Mouse(100, 5);

            DiscountVisitor discountVisitor = new DiscountVisitor();
            double discountMouse = mouse.Accept(discountVisitor);
            double discountKeyBoard = keyBoard.Accept(discountVisitor);

            Console.WriteLine("the mouse has a final price of: {0}", discountMouse);
            Console.WriteLine("the keyboard has a final price of: {0}", discountKeyBoard);

            UnitsOfferVisitor unitsOfferVisitor = new UnitsOfferVisitor();
            double amountMouses = mouse.Accept(unitsOfferVisitor);
            double amountKeyBoards = keyBoard.Accept(unitsOfferVisitor);

            Console.WriteLine("you bought {0} keyboard but you take away: {1}", keyBoard.Amount, amountKeyBoards);
            Console.WriteLine("you bought {0} mouses but you take away: {1}", mouse.Amount, amountMouses);
        }
    }
}
