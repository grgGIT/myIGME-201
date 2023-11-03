using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_GG
{
    public class Program
    {
        static void Main(string[] args)
        {
            ///
            //for Q6 and Q7
            ///

            Tardis tardisObj = new Tardis();
            PhoneBooth phonBotObj = new PhoneBooth();

            UsePhone(tardisObj);

            UsePhone(phonBotObj);

        }
        static void UsePhone(object obj)
        {
            if (obj is PhoneInterface phone)
            {
                phone.MakeCall();
                phone.HangUp();
            }
            else
            {
                Console.WriteLine("Object does not compute.");
            }

            if (obj is Tardis tardisObj)
            {
                tardisObj.TimeTravel();
            }
            else if (obj is PhoneBooth phoneBooth)
            {
                phoneBooth.OpenDoor();
            }
        }
    }
}
