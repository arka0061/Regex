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
            try
            {
                string name = validation.ValidateName(Console.ReadLine());
                if (name.Equals("Sad"))
                    throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_FIRSTNAME, "Invalid FirstName");
            }
            catch (CustomExceptions ex)
            {
                throw ex;

            }
            Console.WriteLine("Enter Last Name :");
            try
            {
                string lastName = validation.ValidateName(Console.ReadLine());
                if (lastName.Equals("Sad"))
                    throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_LASTNAME, "Invalid LastName");
            }
            catch (CustomExceptions ex)
            {
                throw ex;
            }
            Console.WriteLine("Enter Email ID:");
            try
            {
                string email = validation.ValidateEmail(Console.ReadLine());
                if (email.Equals("Sad"))
                    throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_EMAIL, "Invalid EmailAddress");
            }
            catch (CustomExceptions ex)
            {
                throw ex;
            }
            Console.WriteLine("Enter Phone number:");
            try
            {
                string phno = validation.ValidatePhoneNumber(Console.ReadLine());
                if (phno.Equals("Sad"))
                    throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_PHNO, "Invalid Phone Number");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Console.WriteLine("Enter Password");
            try
            {
                string password = validation.ValidatePassword(Console.ReadLine());
                if (password.Equals("Sad"))
                    throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_PASSWORD, "Invalid Password");
            }
            catch (CustomExceptions ex)
            {
                throw ex;
            }
            Console.Write("User Registered Sucessfully!");
        }
    }
}