using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consts;
using System.Security.Cryptography;

namespace StatementProcessor.payment
{
    public class Payment
    {
        bool dateEditoble = true;
        bool storeEditoble = true;
        bool amountEditoble = true;
        bool categoryEditoble = true;


        public virtual string Date { get { return _Date.ToString("d"); } }
        public virtual DateTime _Date { get; set; }
        public virtual bool DateEditoble { get => dateEditoble; protected set { dateEditoble = value;  } }

        public virtual string Store { get; set; }
        public virtual bool StoreEditoble { get => storeEditoble; protected set { storeEditoble = value; } }

        public virtual int Amount { get; set; }
        public virtual bool AmountEditoble { get => amountEditoble; protected set { amountEditoble = value; } }

        private Constants.Category category = Constants.Category.NULL;
        public virtual Constants.Category Category { get => category; set { category = value; } }
        public virtual bool CategoryEditoble { get => categoryEditoble; protected set { categoryEditoble = value; } }

        public int RowNumOfStatement { get; set; }

        public int Sha256OfThis
        {
            get
            {
                string computedString = _Date + Store + Amount.ToString() + Category.ToString() + RowNumOfStatement.ToString();
                SHA256 myHash = SHA256.Create();
                return computedString.GetHashCode();
            }
        }
    }
}
