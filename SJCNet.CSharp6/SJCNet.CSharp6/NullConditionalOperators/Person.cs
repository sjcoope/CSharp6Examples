namespace SJCNet.CSharp6.NullConditionalOperators
{
    public class Person
    {
        public Person(string givenNames, string familyName, int age)
        {
            this.GivenNames = givenNames;
            this.FamilyName = familyName;
            this.Age = age;
        }

        public Person(string familyName)
        {
            this.FamilyName = familyName;
        }

        public int Age { get; private set; }

        public string GivenNames { get; private set; }

        public string FamilyName { get; private set; }

        public string FullName => $"{this.GivenNames} {this.FamilyName}";
    }
}
