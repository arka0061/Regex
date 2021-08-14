using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexValidation
{
    public class SampleEmailValidation
    {
        public const string SAMPLE_EMAIL_VALIDATE = "^[a-zA-z]{3}([+-_ .]*[a-zA-Z0-9]+)*[@][a-zA-z0-9]+(.[a-z]{2,3})*$";
        public List<string> emails = new List<string>();
        public void validateEmail()
        {
            emails.Add("abc@yahoo.com");
            emails.Add("abc.100@yahoo.com");
            emails.Add("abc.100@yahoo.com");
            emails.Add("abc111@abc.com");
            emails.Add("abc100@abc.net");
            emails.Add("adc.100@abc.com.au");
            emails.Add("abc@1.com");
            emails.Add("abc@gmail.com.com");
            emails.Add("abc+100@gmail.com");
            emails.Add("abc");           
            emails.Add("abc");
            emails.Add("abc@.com.my");
            emails.Add("abc123@gmail.a");
            emails.Add("abc123@.com");
            emails.Add("abc123@.com.com");
            emails.Add("abc@abc.com");
            emails.Add("abc{}*@gmail.com");
            emails.Add("abc@%*.com");
            emails.Add("abc...2002@gmail.com");
            emails.Add("abc@gmail.com.");
            emails.Add("abc@abc@gmail.com");
            emails.Add("abc@gmail.com.1a");
            emails.Add("abc@gmail.com.aa.au");

            Regex regex = new Regex(SAMPLE_EMAIL_VALIDATE);
            Console.WriteLine("Validates Email ID");
            Validate(emails, regex);
        }
        public void Validate(List<string> emails, Regex regex)
        {
            foreach (var item in emails)
            {
                bool check = regex.IsMatch(item);
                if (check == true)
                    Console.WriteLine(item + " : " + "Valid Email ID");
                else
                    Console.WriteLine(item + " : " + "Invalid Email ID");
            }
        }
    }
}
