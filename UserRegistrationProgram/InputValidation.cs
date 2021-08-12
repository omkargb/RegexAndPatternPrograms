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
            Console.WriteLine("\n Last name : Starts with Capital alphabet and has minimum 3 characters..");
            const string Regex_Name = "^[A-Z]{1}[A-Za-z]{2,}";

            Console.Write(" Enter Last name : ");
            //string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            if (Regex.IsMatch(lastName, Regex_Name) == true)
            {
                Console.WriteLine(" Last name - Valid");
            }
            else
            {
                Console.WriteLine(" Last name - Not valid");
                UserInput();
            }
        }
    }
}
