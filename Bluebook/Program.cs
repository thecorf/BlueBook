namespace Bluebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();
            person.Age =29;
            person.Name = "Michael";
            person.Class = "1.C";
            person.Birthdate = "21.Sep";

            person1.Age = 21;
            person1.Name = "Marcus";
            person1.Class = "1.C";
            person1.Birthdate = "3. Feb";

            person2.Age = 32;
            person2.Name = "Kurt";
            person2.Class = "4.C";
            person2.Birthdate = "5. Maj";

            person3.Age = 74;
            person3.Name = "Linus";
            person3.Class = "1.C";
            person3.Birthdate = "9. Dec";
            Console.WriteLine(person);
            Console.WriteLine("----------------");
            Console.WriteLine(person1);
            Console.WriteLine("----------------");
            Console.WriteLine(person2);
            Console.WriteLine("----------------");
            Console.WriteLine(person3);
        }
    }
}
