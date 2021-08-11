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
        public string phoneValidate = "^[0-9]{2}[ ]{1}[0-9]{10}$";
        public string passwordRuleOne = "[A-Za-z0-9]{7,}[$&+,:;=?@#|'<>.^*()%!-]{1}";
        public string passwordRuleTwo = "[A-Z]{1,}";
        public string passwordRuleThree = "[0-9]{1,}";
        public bool validateName(string name)
        {
            return Regex.IsMatch(name, nameValidate);
        }
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, emailValidate);
        }
        public bool validatePhoneNumber(string phone)
        {
            return Regex.IsMatch(phone, phoneValidate);
        }
        public bool validatePassRuleOne(string password)
        {
            return Regex.IsMatch(password, passwordRuleone);
        }
        public bool validatePassRuleTwo(string password)
        {
            return Regex.IsMatch(password, passwordRuleTwo);
        }
        public bool validatePassRuleThree(string password)
        {
            return Regex.IsMatch(password, passwordRuleThree);
        }
    }
}



