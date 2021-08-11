using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace RegexValidation
{
    public class Validation
    {
        public string nameValidate = "^[A-Z]{1}[A-Za-z]{3,}$";
        public string emailValidate = "^[a-z]{3,}([.][a-z]{3,})?[@][a-z]{2}[.][co]{2}([.][in]{2})?$";
        public bool validateName(string name)
        {
            return Regex.IsMatch(name, nameValidate);
        }
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, emailValidate);
        }
    }
}
