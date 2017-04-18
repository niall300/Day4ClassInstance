//coffey.niall.com 29/03/2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a Person class with an instance variable, age ,
//    and a constructor that takes an integer, initialAge ,
//    as a parameter.The constructor must assign
//           initialAge to  age after confirming the argument passed as  initialAge is not negative;
//if a negative argument is passed as initialAge, the constructor should set age to zero 
//    and print Age is not valid, setting age to 0..


//In addition, you must write the following instance methods:

//yearPasses() should increase the age instance variable by 1.

//    amIOld() should perform the following conditional actions:
//If age < 13, print You are young..
//If  age >= 13 and age <18 print You are a teenager..
//Otherwise, print You are old..


//    Input Format


//The first line contains an integer,  (the number of test cases),
//and the  subsequent lines each contain an integer denoting the  of a Person instance.


namespace Day4ClassInstance
{
    class Person
    {
        private int age;
        public Person(int initialAge)
        {
            // Add some more code to run some checks on initialAge
            if (initialAge < 0)
            {
                Console.WriteLine("Age is not valid, setting age to 0..");
                this.Age = 0;

            }
            else
            {

                this.Age = initialAge;
            }
        }

        public int Age { get; set; }

        public void amIOld()
        {
            // Do some computations in here and print out the correct statement to the console 
            if (Age < 13)
            {
                Console.WriteLine(" print You are young..");
            }
            else if (Age >= 13 && Age < 18)
            {
                Console.WriteLine("You are a teenager..");
            }
            else
            {
                Console.WriteLine("You are old..");

            }
            //If  age >= 13 and age <18 print You are a teenager..
            //Otherwise, print You are old..

        }

        public void yearPasses()
        {
            // Increment the age of the person in here
            Age++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();

            }
        }
    }
}
