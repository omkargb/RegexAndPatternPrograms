using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class InputValidation
    {
        public void UserInput()
        { 
        }

        const string Regex_Name = "^[A-Z]{1}[A-Za-z]{2,}";
        const string Regex_MobileNum = "^[1-9]{1,2}[ ][1-9]{1}[0-9]{9}$";
        const string Regex_Password = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[~`!@#$%^&*_+=,./?]).{8,}$";
        const string Regex_EmailId = "^[A-Za-z0-9]+([.+-_][A-Za-z0-9]+)*[@][a-zA-Z0-9]+([.][A-Za-z]{2,})+([.][A-Za-z]+)?$";

        public bool TestFirstName(string firstName)
        {
            try
            {
                if (Regex.IsMatch(firstName, Regex_Name))
                { return true; }
                else
                {
                    throw new InvalidDetailsException(InvalidDetailsException.ExceptionType.FIRSTNAME_INVALID, "First_Name is Invalid.");
                }
            }
            catch (InvalidDetailsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public bool TestLastName(string lastName)
        {
            try
            {
                if (Regex.IsMatch(lastName, Regex_Name))
                { return true; }
                else
                {
                    throw new InvalidDetailsException(InvalidDetailsException.ExceptionType.LASTNAME_INVALID, "Last_Name is Invalid.");
                }
            }
            catch (InvalidDetailsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public bool TestMobileNum(string mobileNum)
        {
            try
            {
                if (Regex.IsMatch(mobileNum, Regex_MobileNum))
                { return true; }
                else
                {
                    throw new InvalidDetailsException(InvalidDetailsException.ExceptionType.MOBILENUMBER_INVALID, "Mobile Number is Invalid.");
                }
            }
            catch (InvalidDetailsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public bool TestPassword(string password)
        {
            try
            {
                if (Regex.IsMatch(password, Regex_Password))
                { return true; }
                else
                {
                    throw new InvalidDetailsException(InvalidDetailsException.ExceptionType.PASSWORD_INVALID, "Password is Invalid.");
                }
            }
            catch (InvalidDetailsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public bool TestEmailId(string emailId)
        {
            try
            {
                if (Regex.IsMatch(emailId, Regex_EmailId))
                { return true; }
                else
                {
                    throw new InvalidDetailsException(InvalidDetailsException.ExceptionType.EMAILID_INVALID, "Email-Id is Invalid.");
                }
            }
            catch (InvalidDetailsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

    }
}