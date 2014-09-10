using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Person
    {
        public string firstName = "";
        public string middleName = "";
        public string lastName = "";

        public string GetFullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }

        public string GetReverseName()
        {
            char[] a = GetFullName().ToCharArray();
            string reverseName = "";
            
            for(int i = a.Length - 1; i >=0; i--)
            {
                reverseName += a[i];
            }
            return reverseName;
        }
    }
}
