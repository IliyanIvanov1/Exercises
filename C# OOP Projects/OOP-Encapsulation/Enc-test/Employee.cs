using System;

namespace Enc_test
{
    public class Employee
    {
        private string name;

        private int age;

        private int monthlySalary;


        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;

            Console.WriteLine("Object created");
        }


        public int MonthlySalary
        {
            get
            {
                return this.monthlySalary;
            }
            set
            {
                if (value < 400)
                {
                    throw new ArgumentException($"{nameof(MonthlySalary)} cannot be below 400 leva");
                }
                else
                {
                    this.monthlySalary = value;
                }
                }
        }


        ~Employee()
        {
            Console.WriteLine("Object deleted");
        }


        public string Name//=> this.name; 
        {
            get
            {
                return this.name;
            }
            set
            {
                if(value==null || value.Length < 3)
                {
                    throw new ArgumentException($"{nameof(Name)} cannot be null or less than 3 symbols");
                }
            }
        }                                
    public int Age
        {
            get
            {
                return this.age;

            }
            set
            {
                if (value<18)
                {
                    throw new ArgumentException($"{nameof(Age)} cannot be under 18");
                }
                this.age = value;
            }
        }

    }
}
