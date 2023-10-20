using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14_Gracia
{
    //Author: Geoff Gracia
    //Purpose: answer to questions 1 thru 3
    //Restrictions: none

    //Question 1
    public abstract class MyAbstractClass
    {
        private int myPrivateField;

        // Public property to access the private field
        public int MyProperty
        {
            get
            {
                return myPrivateField;
            }
            set
            {
                myPrivateField = value;
            }
        }
    }

    //
    //
    //

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
