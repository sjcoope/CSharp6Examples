
namespace SJCNet.CSharp6.NameOf
{
    public class Person
    {
        public Person(Genders gender)
        {
            this.Gender = gender;
        }

        public string GivenNames{ get; set; }

        public string FamilyName { get; set; }

        public int Age { get; set; }

        public Genders Gender { get; }
    }
}
