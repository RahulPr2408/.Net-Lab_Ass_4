using System;

namespace Code_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TimePeriod t = new TimePeriod();
            // The property assignment causes the 'set' accessor to be called.
            t.Hours = 24;

            // Retrieving the property causes the 'get' accessor to be called.
            Console.WriteLine($"Time in hours: {t.Hours}");

            var person = new Person("Rahul", "Prajapati");
            Console.WriteLine(person.Name);

            var item = new SaleItem{ Name = "Shoes", Price = 19.95m };
            Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");

        }
    }

    class TimePeriod {

        private double _seconds;

        public double Hours {
            get { return _seconds / 3600; }
            set {
                if(value < 0 || value > 24) {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 24.");
                }
                _seconds = value * 3600;
            }
        }
    }

    public class Person {
        private string _firstName;
        private string _lastName;

        public Person(string first, string last)
        {
            _firstName = first;
            _lastName = last;
        }

        public string Name => $"{_firstName} {_lastName}";
    }

    public class SaleItem
    {
        public string Name
        { get; set; }

        public decimal Price
        { get; set; }
    }
}
