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
            string name = Console.ReadLine();
            Console.WriteLine("Enter Last Name :");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Email ID:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Phone number:");
            string phno = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            if (validation.validateName(name) == true && validation.validateName(lastName) && validation.validateEmail(email) && validation.validatePhoneNumber(phno) 
                && validation.validatePassRuleOne(password)
                && validation.validatePassRuleTwo(password)&& validation.validatePassRuleThree(password))
            {
                Console.WriteLine("Username :" + name + " " + lastName);
                Console.WriteLine("Email id :" + email);
                Console.WriteLine("Phone Number is :" + phno);
                Console.WriteLine("Password is :" + password);
            }
            else
                Console.WriteLine("Enter name in correct format!");
        }
    }
}