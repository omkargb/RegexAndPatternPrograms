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
            const string Regex_Password = "^[a-zA-Z0-9_!-+@#$]{8,}$";
            Console.WriteLine("\n Password Rule --> 1]Minimum 8 Characters");
            Console.Write("\n Enter password : ");
            string password = Console.ReadLine();

            if (Regex.IsMatch(password, Regex_Password) == true)
            {
                Console.WriteLine(" Password is in correct format. ");
            }
            else
            {
                Console.WriteLine(" Password is Not in correct format. ");
                UserInput();
            }

            //const string Regex_MobileNum = "^[1-9]{1,2}[ ][1-9]{1}[0-9]{9}$";
            //Console.Write("\n Enter your mobile number (CountryCode 10DigitNumber) : ");
            //string mobile = Console.ReadLine();

            //if (Regex.IsMatch(mobile, Regex_MobileNum) == true)
            //{
            //    Console.WriteLine(" Mobile number is Valid. ");
            //}
            //else
            //{
            //    Console.WriteLine(" Mobile number is Not Valid. ");
            //    UserInput();
            //}
            //const string Regex_EmailId = "^[A-Za-z0-9]+([.+-_][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][A-Za-z]+([.][A-Za-z]+)?$";

            //Console.Write(" Enter your email-Id : ");
            //string email = Console.ReadLine();

            //if (Regex.IsMatch(email, Regex_EmailId) == true)
            //{
            //    Console.WriteLine(" Email Id - Valid");
            //}
            //else
            //{
            //    Console.WriteLine(" Email Id - Not valid");
            //    UserInput();
            //}
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
