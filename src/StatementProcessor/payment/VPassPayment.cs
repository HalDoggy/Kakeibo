using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementProcessor.payment
{
    public class VPassPayment : Payment
    {

        public VPassPayment() : base()
        {
            base.DateEditoble = false;
            base.StoreEditoble = false;
            base.AmountEditoble = false;
        }
    }
}
