using System;

namespace RegexValidation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Validation!");
            SampleEmailValidation sample = new SampleEmailValidation();
            sample.validateEmail();
            Validation validation = new Validation();
            Console.WriteLine("Enter First Name :");
            string name = validation.ValidateName(Console.ReadLine());
            if (name.Equals("Happy"))
                Console.WriteLine("Enter Last Name :");
            else
                Console.WriteLine("InCorrect Input!");
            string lastName = validation.ValidateName(Console.ReadLine());
            if (lastName.Equals("Happy"))
                Console.WriteLine("Enter Email ID:");
            else
                Console.WriteLine("InCorrect Input!");
            string email = validation.ValidateEmail(Console.ReadLine());
            if (email.Equals("Happy"))
                Console.WriteLine("Enter Phone number:");
            else
                Console.WriteLine("InCorrect Input!");
            string phno = validation.ValidatePhoneNumber(Console.ReadLine());
            if (phno.Equals("Happy"))
                Console.WriteLine("Enter Password");
            else
                Console.WriteLine("InCorrect Input!");
            string password = validation.ValidatePassword(Console.ReadLine());
            if (password.Equals("Happy"))
            {
                Console.WriteLine("Username :" + name + " " + lastName);
                Console.WriteLine("Email id :" + email);
                Console.WriteLine("Phone Number is :" + phno);
                Console.WriteLine("Password is :" + password);
            }
            else
                Console.WriteLine("InCorrect Input!");
        }
    }

}