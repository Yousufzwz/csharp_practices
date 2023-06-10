using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask_04
{
    internal class GiftCard : Item
    {
        protected GiftCard(double price) : base(price)
        {
        }

        protected override double GetDiscount(double originalPrice)
        {
            throw new NotImplementedException();
        }
    }
}
