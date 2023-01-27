using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpMasterClass
{
   public class ForEachLoopsAndSwitch
    {
        private static string value1  { get; set; }
        private static string value2 { get; set; }


        public static string GetInputValue()
        {
        Console.WriteLine("Enter a value and I will tell you what type of value it is:");
           value1 = Console.ReadLine();
            Console.WriteLine("What input type did you provide? " + "\n" + "Press 1 for String " + "\n" + "Press 2 for integer" + "\n" + "Press 3 for boolean");
            value2 = Console.ReadLine();

            switch (value2)
            {
                case "1":
                    IsAnswerAStringBoolOrInteger(value1);
                    ReturnType(value1, value2);
                    break;
                case "2":
                    IsAnswerAStringBoolOrInteger(value1);
                    ReturnType(value1, value2);
                    break;
                case "3":
                    IsAnswerAStringBoolOrInteger(value1);
                    ReturnType(value1, value2);
                    break;
                default:
                    Console.WriteLine("You entered an invalid choice");
                    break;
            }
            
            

            return  value2;
        }

        private static bool IsAnswerAStringBoolOrInteger (string value1)
        {
            bool result = false;


            foreach (var character in value1)
            {
                if ((value1 == "true") || (value1 == "false") || (value1 == "yes") || (value1=="no"))
                {
                    result = true;
                }
                else if (value1.All(char.IsDigit)){
                    result = true;
                }
                else if (value1.All(Char.IsLetter))
                    {
                    result = true;
                }
                


            }
          

            return result;
               
        }

        private static string ReturnType(string value1, string value2)
        {
            Type valueType = value1.GetType();
            Type stringValue = typeof(string);
            int intValue = Int16.Parse(value1);
 
            Type integerVal = intValue.GetType();
            Type boolValue = typeof(bool);

            if ((valueType == stringValue) && (value2 =="1"))
                
            {
                Console.WriteLine("You entered a string");
            }
           else  if ((int.TryParse(value1, out intValue)) && (value2 == "2"))
            
            {
                Console.WriteLine("You entered an integer");
            }

            else if ((valueType == boolValue  && value2 == "3"))
            {
                Console.WriteLine("You entered an boolean");
            }
         else if ((valueType !=stringValue) && (valueType != integerVal) && (valueType != boolValue))
            {
                Console.WriteLine("You entered the wrong type");
            }
            return value1.GetType().ToString();
        }

    

        
        //Create an application that takes 2 input values
        // 1st input (any type)
        // 2nd input asks the data type of the inut value.
        // Print on the console. Press 1 for string, 2 for integer 3 for boolean
        //# If the input value for the 2nd input is 1 then the application should check that if the entered 1st input is a valid string or not. Hereby we even want to check, if it is a complete alphabetic entry (so no numbers accepted)

        //        If the input value for the 2nd input is 2 then the application should check if the entered 1st input is a valid integer or not.

        //        Based on the input the 1st value and the selection of data type using the 2nd input, the application should return whether the entered 1st value is of data type selected by the user or not.

        //        Please make sure to use a switch statement.To check the valid string you can write your custom logic.

        //       For example:

        //Enter a value: {here you can enter any value}

        //Select the Data type to validate the input you have entered.

        //Press 1 for String

        //Press 2 for Integer

        //Press 3 for Boolean

        //Here, if you enter 1 it should return below message

        //You have entered a value: Denis Panjuta

        //It is a valid: String

        //Here, if you enter 2 it should return below message

        //You have entered a value: Denis Panjuta

        //It is an invalid: Integer



        //PS: You may want to check what is isLetter method in c#



       
    }
}
