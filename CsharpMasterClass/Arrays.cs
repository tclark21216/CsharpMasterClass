using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpMasterClass
{
   public class Arrays
    {
        public static void UseJaggedArrays()
        {

            //datatype [] arrayName;

            //initialize an array
            //dataType [] arrayName = new dataType [amountof Entries]


            //assign values to an array
            //arrayName [index] = value;


            string[] names = new string[4];
            names[0] = "Midnight";
            names[1] = "Chi Chi";
            names[2] = "Duchess";
            names[3] = "Missy";


            //int[] grades = { 20, 55, 65, 95, 78 };

            //Console.WriteLine("Length of the array: {0}", grades.Length);
      


            //Console.WriteLine("grades at index 0{0}:",grades[0] );

        }

        public static void GetOdd(int [] oddNumbers)
        {
            
            for (int i = 1; i < oddNumbers.Length; i++)
            {
                if( oddNumbers[i] % 3 == 0)

             
                
                    Console.WriteLine(oddNumbers[i]);
                
            }

           
        }

        public static void GetEven(int[] evenNumbers) {
            
            for (int i = 0; i < evenNumbers.Length; i++)
            {
                
                if (evenNumbers[i] % 2 == 0)
                {
                    Console.WriteLine(evenNumbers[i]);
                }

                                
            }
                
               
            }
        }


    }

