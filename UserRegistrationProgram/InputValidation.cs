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
            
            const string Regex_EmailId = "^[A-Za-z0-9]+([.+-_][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][A-Za-z]+([.][A-Za-z]+)?$";

            Console.Write(" Enter your email-Id : ");
            string email = Console.ReadLine();

            if (Regex.IsMatch(email, Regex_EmailId) == true)
            {
                Console.WriteLine(" Email Id - Valid");
            }
            else
            {
                Console.WriteLine(" Email Id - Not valid");
                UserInput();
            }

            //const string Regex_Name = "^[A-Z]{1}[A-Za-z]{2,}";
            //Console.WriteLine("\n Last name : Starts with Capital alphabet and has minimum 3 characters..");
            //Console.Write(" Enter Last name : ");
            //string firstName = Console.ReadLine();
            //string lastName = Console.ReadLine();
            //if (Regex.IsMatch(lastName, Regex_Name) == true)
            //{
            //    Console.WriteLine(" Last name - Valid");
            //}
            //else
            //{
            //    Console.WriteLine(" Last name - Not valid");
            //    UserInput();
            //}
        }
    }
}
