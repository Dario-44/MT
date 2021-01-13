using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyTracker
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Person(string firstname1, string lastname1)
        {
            Firstname = firstname1;
            Lastname = lastname1;
        }
    }
}
