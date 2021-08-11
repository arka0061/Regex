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
            if (validation.validateName(name) == true && validation.validateName(lastName))
                Console.WriteLine("Username :"+name+" "+lastName);
            else
                Console.WriteLine("Enter name in correct format!");
        }
    }
}
