using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15_Gracia
{
    public class Customer : Interface1
    {
        public string name;
        private string creditCardNumber;
        public string CreditCardNumber
        {
            set
            {
                this.creditCardNumber = value;
            }
        }

        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
    }
}
