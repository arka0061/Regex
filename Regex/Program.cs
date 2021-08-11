using System;

namespace RegexValidation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Validation!");
            Validation validation = new Validation();
            Console.WriteLine("Enter First Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Last Name :");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Email ID:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Phone number:");           
            string phno = Console.ReadLine();
            if (validation.validateName(name) == true && validation.validateName(lastName) && validation.validateEmail(email) && validation.validatePhoneNumber(phno))
            {
                Console.WriteLine("Username :" + name + " " + lastName);
                Console.WriteLine("Email id :" + email);
                Console.WriteLine("Phone Number is :" + phno);               
            }
            else
                Console.WriteLine("Enter name in correct format!");
        }
    }
}

