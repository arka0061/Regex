using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace RegexValidation
{
    public class Validation
    {
        public const string NAME_VALIDATE = "^[A-Z]{1}[A-Za-z]{3,}$";
        public const string EMAIL_VALIDATE = "^[a-z]{1,}([.][a-z]{1,})?[@][a-z]{2}[.][a-z]{2}([.][a-z]{2})?$";
        public const string PHONE_VALIDATE = "^[0-9]{2}[ ]{1}[0-9]{10}$";
        public const string PASSWORD_RULE_ONE = "[A-Za-z0-9]{7,}[$&+,:;=?@#|'<>.^*()%!-]{1}";
        public const string PASSWROD_RULE_TWO = "[A-Z]{1,}";
        public const string PASSWORD_RULE_THREE = "[0-9]{1,}";
        public bool validateName(string name)
        {
            return Regex.IsMatch(name, NAME_VALIDATE);
        }
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, EMAIL_VALIDATE);
        }
        public bool validatePhoneNumber(string phone)
        {
            return Regex.IsMatch(phone, PHONE_VALIDATE);
        }
        public bool validatePassRuleOne(string password)
        {
            return Regex.IsMatch(password, PASSWORD_RULE_ONE);
        }
        public bool validatePassRuleTwo(string password)
        {
            return Regex.IsMatch(password, PASSWROD_RULE_TWO);
        }
        public bool validatePassRuleThree(string password)
        {
            return Regex.IsMatch(password, PASSWORD_RULE_THREE);
        }
    }
}



