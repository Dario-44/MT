using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyTracker
{
    class Person
    {
        internal string Firstname { get; set; }
        internal string Lastname { get; set; }

        public Person(string firstname1, string lastname1)
        {
            Firstname = firstname1;
            Lastname = lastname1;
        }
    }
}
