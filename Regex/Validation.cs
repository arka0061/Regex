using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace RegexValidation
{
    public class Validation
    {
        public string nameValidate = "^[A-Z]{1}[A-Za-z]{3,}$";
        public bool validateName(string name)
        {
            return Regex.IsMatch(name, nameValidate);
        }     
    }
}
