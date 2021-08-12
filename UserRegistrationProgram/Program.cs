using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to User Registration Program and Input validation using RegEx ");

            InputValidation validate = new InputValidation();
            validate.UserInput();
        }
    }
}
