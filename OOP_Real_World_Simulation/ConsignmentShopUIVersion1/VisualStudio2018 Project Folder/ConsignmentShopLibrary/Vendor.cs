using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Commission { get; set; }

        public decimal PaymentDue { get; set; }

        // ctor then tab twice 

        // the Vendor constructor
        public Vendor()
        {
            Commission = 0.5;
        }

        ~ Vendor()
        {

        }

        public string Display
        {
            get
            {
                // a return string in the format of "title - $price"
                return string.Format("{0} {1} - Commission: $.{2}", FirstName, LastName, PaymentDue);
            }
        }
    }
}
