﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class InputValidation
    {
        public void UserInput()
        {

            const string Regex_EmailId = "^[A-Za-z0-9]+([.+-_][A-Za-z0-9]+)*(([@][a-zA-Z0-9]{1,}){1})+([.][A-Za-z]{2,3})+(([.][A-Za-z]{2,3}))?$";

            string[] inputMails = { "abc@yahoo.com", 
            "abc-100@yahoo.com", 
            "abc.100@yahoo.com", 
            "abc111@abc.com",
            "abc-100@abc.net",
            "abc.100@abc.com.au", 
            "abc@1.com", 
            "abc@gmail.com.com", 
            "abc+100@gmail.com" ,
            "abc",
            "abc@.com.my",
            "abc123@gmail.a", 
            "abc123@.com" ,
            "abc123@.com.com",
            ".abc@abc.com",
            "abc()*@gmail.com",
            "abc@%*.com",
            "abc..2002@gmail.com",
            "abc.@gmail.com",
            "abc@abc@gmail.com",
            "abc@gmail.com.1a",
            "abc@gmail.com.aa.au"};

            Console.WriteLine("\n Validating sample Email-Ids :-- \n");
            for (int id = 0; id < inputMails.Length; id++)
            {
                if (Regex.IsMatch(inputMails[id], Regex_EmailId) == true)
                { Console.WriteLine(" {0} \t\t : Valid", inputMails[id]); }
                else
                { Console.WriteLine(" {0} \t\t : Invalid", inputMails[id]); }
            }
            //const string Regex_Password = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[~`!@#$%^&*_+=,./?]).{8,}$";
            ////(?=.*[A-Z]) - atleast 1 capital letter
            ////(?=.*[0-9]) - atleast 1 number
            //Console.WriteLine("\n Password Rules --> 1]Minimum 8 Characters\t2]At least 1 capital alphabet\t3]At least 1 number\t4]Special char");
            //Console.Write("\n Enter password : ");
            //string password = Console.ReadLine();

            //if (Regex.IsMatch(password, Regex_Password) == true)
            //{
            //    Console.WriteLine(" Password is in correct format. ");
            //}
            //else
            //{
            //    Console.WriteLine(" Password is Not in correct format. ");
            //    UserInput();
            //}
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
