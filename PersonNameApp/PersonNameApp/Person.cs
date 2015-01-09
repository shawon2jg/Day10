using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonNameApp
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;

        public string GetFullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }

        public string GetReverseName()
        {
            string fullName = GetFullName();
            string reverseName = String.Empty;
            for (int i = fullName.Length - 1; i > -1; i--)
            {
                reverseName += fullName[i];
            }
            return reverseName;
        }
    }
}
