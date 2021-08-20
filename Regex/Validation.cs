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
        public string ValidateName(string name)
        {
            Regex regex = new Regex(NAME_VALIDATE);
            bool check = regex.IsMatch(name);
            if (check == true)
                return "Happy";
            else
                return "Sad";
        }
        public string ValidateEmail(string email)
        {
            Regex regex = new Regex(EMAIL_VALIDATE);
            bool check = regex.IsMatch(email);
            if (check == true)
                return "Happy";
            else
                return "Sad";
        }
        public string ValidatePhoneNumber(string phone)
        {
            Regex regex = new Regex(PHONE_VALIDATE);
            bool check = regex.IsMatch(phone);
            if (check == true)
                return "Happy";
            else
                return "Sad";
        }
        public string ValidatePassRuleOne(string password)
        {
            Regex regex = new Regex(PASSWORD_RULE_ONE);
            bool check = regex.IsMatch(password);
            if (check == true)
                return "Happy";
            else
                return "Sad";
        }
        public string ValidatePassRuleTwo(string password)
        {
            Regex regex = new Regex(PASSWROD_RULE_TWO);
            bool check = regex.IsMatch(password);
            if (check == true)
                return "Happy";
            else
                return "Sad";
        }
        public string ValidatePassRuleThree(string password)
        {
            Regex regex = new Regex(PASSWORD_RULE_THREE);
            bool check = regex.IsMatch(password);
            if (check == true)
                return "Happy";
            else
                return "Sad";
        }
        public string ValidateMultipleEmail(string email)
        {
            Regex regex = new Regex(PASSWORD_RULE_ONE);
            Regex regex1 = new Regex(PASSWROD_RULE_TWO);
            Regex regex2 = new Regex(PASSWORD_RULE_THREE);
            if (regex.IsMatch(email) & regex1.IsMatch(email) & regex2.IsMatch(email))
            {
                return "Happy";
            }
            else
            {
                return "False";
            }

        }
    }
}



