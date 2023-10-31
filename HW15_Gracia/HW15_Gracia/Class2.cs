using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15_Gracia
{
    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string brand;
        public string size;

        public Customer customer;

        public HotDrink()
        {
            this.instant = false;
            this.milk = false;
            this.sugar = 0;
            this.size = "medium";

            this.customer = new Customer();
        }

        public HotDrink(string brand)
        {
            // Folgers is instant coffee
            if (brand == "Folgers")
            {
                this.instant = true;
            }

            this.brand = brand;

            this.customer = new Customer();
        }

        public virtual void AddSugar(byte amount)
        {
            sugar += amount;
        }

        public abstract void Steam();
    }
}
