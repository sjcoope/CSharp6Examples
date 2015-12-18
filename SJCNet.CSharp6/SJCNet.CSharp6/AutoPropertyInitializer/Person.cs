using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJCNet.CSharp6.AutoPropertyInitializer
{
    public class Person
    {
        public Person()
        {}

        public Person(string givenNames, string familyName, int age)
        {
            this.GivenNames = givenNames;
            this.FamilyName = familyName;
            this.Age = age;
        }

        public string GivenNames{ get; set; } = "John";

        public string FamilyName { get; set; } = "Smith";

        public int Age { get; set; } = 30;

    }
}
