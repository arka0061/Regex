using System;

namespace RegexValidation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Validation!");
            Validation validation = new Validation();
            Console.WriteLine(validation.validateName("Arka"));
        }
    }
}
