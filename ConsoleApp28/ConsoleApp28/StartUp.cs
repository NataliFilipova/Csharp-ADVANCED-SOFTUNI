using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            /*
            string name = "Pesho";
            int age = 24;
            Person pesho = new Person()
            {
                Name = name,
                Age = age
            };

            Console.WriteLine($"{pesho.Name} - {pesho.Age}");

            var noName = new Person();
            Console.WriteLine($"{noName.Name} - {noName.Age}");

            var george = new Person(24);
            Console.WriteLine($"{george.Name} - {george.Age}");

            var ivan = new Person("Ivan", 27);
            Console.WriteLine($"{ivan.Name} - {ivan.Age}");

            */
            var family = new Family();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i ++)
            {
                var cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = cmdArgs[0];
                int age = int.Parse(cmdArgs[1]);
                var person = new Person(name, age);
                family.AddMember(person);

            }
            //T03
            //Console.WriteLine(family.GetOldestMember());

            HashSet<Person> personAbove30 = family.GetAllPeopleAbove30();

            Console.WriteLine(string.Join(Environment.NewLine, personAbove30));
        }
    }
}
