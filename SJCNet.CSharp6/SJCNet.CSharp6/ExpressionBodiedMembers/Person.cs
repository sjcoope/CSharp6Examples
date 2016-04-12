namespace SJCNet.CSharp6.ExpressionBodiedMembers
{
    public class Person
    {
        public Person(string givenNames, string familyName, int age)
        {
            this.GivenNames = givenNames;
            this.FamilyName = familyName;
            this.Age = age;
        }

        public int Age { get; private set; }

        public string GivenNames { get; private set; }

        public string FamilyName { get; private set; }

        // Block-Bodied Property
        //public string FullName
        //{
        //    get
        //    {
        //        return $"{this.GivenNames} {this.FamilyName}";
        //    }
        //}

        // Expression-Bodied Property
        public string FullName => $"{this.GivenNames} {this.FamilyName}";

        // Block-Bodied Method
        //public string Greet(string greeting)
        //{
        //    return $"{greeting}, my name is {this.FullName} and I am {this.Age} years old.";
        //}

        // Expression-Bodied Method
        public string Greet(string greeting) => $"{greeting}, my name is {this.FullName} and I am {this.Age} years old.";
    }
}
