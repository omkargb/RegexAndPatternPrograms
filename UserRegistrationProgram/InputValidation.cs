using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class InputValidation
    {
        public void UserInput()
        {
            Console.WriteLine("\n First name : Starts with Capital alphabet and has minimum 3 characters..");
            const string Regex_Name = "^[A-Z]{1}[A-Za-z]{2,}";

            Console.Write(" Enter First name : ");
            string firstName = Console.ReadLine();
            if (Regex.IsMatch(firstName, Regex_Name) == true)
            {
                Console.WriteLine(" First name - Valid");
            }
            else
            {
                Console.WriteLine(" First name - Not valid");
                UserInput();
            }
        }
    }
}
