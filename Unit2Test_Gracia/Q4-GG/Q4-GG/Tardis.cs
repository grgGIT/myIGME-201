using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_GG
{
    public class Tardis: PhoneInterface
    {
        private bool Screwdriver
        {
            get; set;
        }
        private byte whicDrWho
        {
            get; set;
        }
        private string femaleSideKick
        {
            get; set;
        }
        public double exteriorSurfaceArea
        {
            get; set;
        }

        public double interiorVolume
        {
            get; set;
        }
        public byte WhichDrWho
        {
            get; 
        }

        public string FemaleSideKick
        {
            get; 
        }
        public void TimeTravel()
        {

        }

        /// 
        //Q5
        ///

        // Overload the equality operators (== and !=)
        public static bool operator ==(Tardis left, Tardis right)
        {
            if (left is null)
                return right is null;
            return left.Equals(right);
        }

        public static bool operator !=(Tardis left, Tardis right)
        {
            return !(left == right);
        }

        // Overload the comparison operators (<, >, <=, and >=)
        public static bool operator <(Tardis left, Tardis right)
        {
            if (left is null)
                return !(right is null);
            return left.CompareTo(right) < 0;
        }

        public static bool operator >(Tardis left, Tardis right)
        {
            if (left is null)
                return false;
            return left.CompareTo(right) > 0;
        }

        public static bool operator <=(Tardis left, Tardis right)
        {
            return !(left > right);
        }

        public static bool operator >=(Tardis left, Tardis right)
        {
            return !(left < right);
        }

        public override bool Equals(object obj)
        {
            if (obj is Tardis otherTardis)
            {
                if (WhichDrWho == 10)
                {
                    return otherTardis.WhichDrWho != 10;
                }
                return WhichDrWho < otherTardis.WhichDrWho;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return WhichDrWho.GetHashCode();
        }

        public int CompareTo(Tardis otherTardis)
        {
            if (WhichDrWho == 10)
            {
                if (otherTardis.WhichDrWho != 10)
                    return 1;
            }
            return WhichDrWho.CompareTo(otherTardis.WhichDrWho);
        }

        /// 
        //Q6
        ///
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
