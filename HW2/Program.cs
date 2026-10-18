using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====Management Person programer=====");

            Person[] persons = new Person[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Input Information of Person");
                
                Console.Write("Please input name: ");
                string name = Console.ReadLine();

                Console.Write("Please input address: ");
                string address = Console.ReadLine();

                Person person = null;
                while (person == null)
                {
                    Console.Write("Please input salary: ");
                    string sSalary = Console.ReadLine();

                    try
                    {
                        person = Person.InputPersonInfo(name, address, sSalary);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                persons[i] = person;
            }

            try
            {
                persons = Person.SortBySalary(persons);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (Person p in persons)
            {
                Console.WriteLine("Information of Person you have entered:");
                Person.DisplayPersonInfo(p);
            }
        }
    }
}