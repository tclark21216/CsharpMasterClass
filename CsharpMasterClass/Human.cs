using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpMasterClass
{
    class Human
    {
       private string firstName;
       private string lastName;
        private string eyecolor;
        private int age;


        public Human()
        {
            Console.WriteLine("Basic Constructor");
        }

        public Human(string firstName)
        {
            this.firstName = firstName;


            //variable in this is the global variable listed directly under the class name
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
           

            //variable in this is the global variable listed directly under the class name
        }
    
        //constructor (must have the same name as the class)

        public Human(string firstName, string lastName, string eyecolor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyecolor = eyecolor;
            this.age = age;

            //variable in this is the global variable listed directly under the class name
        }

        public  void Introduction()
        {


            //Console.WriteLine("Hi, my name is { 0} { 1} and my eyes are { 2} and I am { 3}  years old. This is in dog years", firstName, lastName, eyecolor, age);
            if ((age != 0) && (firstName != null) && (lastName !=null)&&(eyecolor!=null))
            {
                Console.WriteLine("Hi, my name is {0} {1} and my eyes are {2} and I am {3} years old.", firstName, lastName, eyecolor, age);

            }


            Console.WriteLine("Hi, my name is {0}{1}", firstName, lastName);
            Console.WriteLine("Hi my first name is {0}", firstName);
        }
    }
}
