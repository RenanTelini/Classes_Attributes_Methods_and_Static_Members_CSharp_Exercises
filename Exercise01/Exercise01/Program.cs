using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1, person2;

            person1 = new Person();
            person2 = new Person();

            Console.WriteLine("First person's details:");
            Console.Write("Name: ");
            person1.Name = Console.ReadLine();
            Console.Write("Age: ");
            person1.Age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Second person's details:");
            Console.Write("Name: ");
            person2.Name = Console.ReadLine();
            Console.Write("Age: ");
            person2.Age = int.Parse(Console.ReadLine());

            if (person1.Age > person2.Age)
                Console.WriteLine("Older person: {0}", person1.Name);
            else
                Console.WriteLine("Older person: {0}", person2.Name);
        }
    }
}