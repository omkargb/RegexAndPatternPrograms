using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class InputValidation
    {
        const string Regex_Name = "^[A-Z]{1}[A-Za-z]{2,}";
        const string Regex_MobileNum = "^[1-9]{1,2}[ ][1-9]{1}[0-9]{9}$";
        const string Regex_Password = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[~`!@#$%^&*_+=,./?]).{8,}$";
        const string Regex_EmailId = "^[A-Za-z0-9]+([.+-_][A-Za-z0-9]+)*[@][a-zA-Z0-9]+([.][A-Za-z]{2,})+([.][A-Za-z]+)?$";

        //using lambda function
        public bool TestFirstName(string firstName) => (Regex.IsMatch(firstName, Regex_Name));
        
        public bool TestLastName(string lastName) => (Regex.IsMatch(lastName, Regex_Name));
        
        public bool TestMobileNum(string mobileNum) => (Regex.IsMatch(mobileNum, Regex_MobileNum));
        
        public bool TestPassword(string password) => (Regex.IsMatch(password, Regex_Password));
        
        public bool TestEmailId(string emailId) => (Regex.IsMatch(emailId, Regex_EmailId));


    }
}