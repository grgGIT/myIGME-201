using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_GG
{
    public class PhoneBooth: PhoneInterface
    {
        private bool superMan { get; set; }
        public double costPerCall { get; set; }
        public bool phoneBook { get; set; }

        public void OpenDoor()
        {

        }
        public void CloseDoor()
        {

        }

        public void Answer()
        {
            throw new NotImplementedException();
        }

        public void MakeCall()
        {
            throw new NotImplementedException();
        }

        public void HangUp()
        {
            throw new NotImplementedException();
        }
    }
}
