using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15_Gracia
{
    public class CupOfCoffee : HotDrink
    {
        public string beanType;

        public CupOfCoffee()
        {

        }

        public CupOfCoffee(string brand) : base(brand)
        {
            if (brand == "Folgers")
            {
                this.beanType = "rancid";
            }
        }

        public override void Steam()
        {
        }
    }
}
