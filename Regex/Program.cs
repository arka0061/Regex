using System;

namespace RegexValidation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Validation!");
            Validation validation = new Validation();
            Console.WriteLine("Enter a Name :");
            string name = Console.ReadLine();
            if (validation.validateName(name) == true)
                Console.WriteLine("Username :"+name);
            else
                Console.WriteLine("Enter name in correct format!");
        }
    }
}
