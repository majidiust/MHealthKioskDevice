using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MHealthKiosk.MultiModule
{
    class Tools
    {
        public static bool isValidNationalID(String id)
        {
            if (id.Length != 10)
                return false;

            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                int digit = int.Parse("" + (id[i]));
                sum += digit * (10 - i);
            }

            int remainder = sum % 11;

            if (remainder >= 2)
                remainder = 11 - remainder;

            if (remainder.ToString().CompareTo("" + (id[9])) == 0)
                return true;

            return false;
        }

        public static bool isValidPhoneNumber(String phoneNumber)
        {
            if (phoneNumber.Length != ("09197343303").Length)
                return false;
            else if (phoneNumber[0] != '0')
                return false;
            else return true;
        }
    }
}
