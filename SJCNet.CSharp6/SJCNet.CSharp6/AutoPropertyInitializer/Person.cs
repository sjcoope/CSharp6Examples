
namespace SJCNet.CSharp6.AutoPropertyInitializer
{
    public class Person
    {
        public Person()
        {}

        public Person(string givenNames, string familyName, int age, Genders gender)
        {
            this.GivenNames = givenNames;
            this.FamilyName = familyName;
            this.Age = age;
            this.Gender = gender;
        }

        public Person(Genders gender)
        {
            this.Gender = gender;
        }

        public string GivenNames{ get; set; } = "John";

        public string FamilyName { get; set; } = "Smith";

        public int Age { get; set; } = 30;

        public Genders Gender { get; } = Genders.Male;
    }
}
