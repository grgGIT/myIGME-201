using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_GG
{
    public abstract class Phone
    {
        private string phoneNumber { get; set; }
        public string address { get; set; }
        public string PhoneNumber { get; set; }

        public abstract void Connect();
        public abstract void Disconnect();
    }
}
