using System;

namespace HW2
{
    public class Person
    {
        private string name;
        private string address;
        private double salary;

        public Person() { }

        public Person(string name, string address, double salary)
        {
            this.name = name;
            this.address = address;
            this.salary = salary;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public static Person InputPersonInfo(string name, string address, string Salary)
        {
            if (string.IsNullOrWhiteSpace(Salary))
            {
                throw new Exception("You must input Salary.");
            }

            double salary;
            bool isNumber = double.TryParse(Salary, out salary);

            if (!isNumber)
            {
                throw new Exception("You must input digidt.");
            }

            if (salary <= 0)
            {
                throw new Exception("Salary is greater than zero");
            }

            return new Person(name, address, salary);
        }

        public static void DisplayPersonInfo(Person person)
        {
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Address: {person.Address}");
            Console.WriteLine($"Salary: {person.Salary:F1}");
        }

        public static Person[] SortBySalary(Person[] person)
        {
            if (person == null || person.Length == 0)
            {
                throw new Exception("Can't Sort Person");
            }

            int n = person.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (person[j].Salary > person[j + 1].Salary)
                    {
                        Person temp = person[j];
                        person[j] = person[j + 1];
                        person[j + 1] = temp;
                    }
                }
            }

            return person;
        }
    }
}