using NUnit.Framework;
using RegexValidation;

namespace RegexTesting
{
    public class Tests
    {
        /// <summary>
        /// Valid Test Cases
        /// </summary>
        [Test]
        public void GivenValidFirstName_WhenAnalyze_ShouldReturnHappy()
        {
            string actual = "Happy";
            Validation user = new Validation();
            string expected = user.ValidateName("Arka");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenValidLastName_WhenAnalyze_ShouldReturnHappy()
        {
            string actual = "Happy";
            Validation user = new Validation();
            string expected = user.ValidateName("Parui");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenValidEmailAddress_WhenAnalyze_ShouldReturnHappy()
        {
            string actual = "Happy";
            Validation user = new Validation();
            string expected = user.ValidateEmail("abc.xyz@bl.co.in");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenValidPhoneNumber_WhenAnalyze_ShouldReturnHappy()
        {
            string actual = "Happy";
            Validation user = new Validation();
            string expected = user.ValidatePhoneNumber("91 9738456781");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenValidPasswordRuleOne_WhenAnalyze_ShouldReturnHappy()
        {
            string actual = "Happy";
            Validation user = new Validation();
            string expected = user.ValidatePassRuleOne("abcdefghi@");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenValidPasswordRuleTwo_WhenAnalyze_ShouldReturnHappy()
        {
            string actual = "Happy";
            Validation user = new Validation();
            string expected = user.ValidatePassRuleTwo("Abcdefgh");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenValidPassWordRuleThree_WhenAnalyze_ShouldReturnHappy()
        {
            string actual = "Happy";
            Validation user = new Validation();
            string expected = user.ValidatePassRuleThree("Abcd1fgh");
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// Invalid Test Cases
        /// </summary>
        [Test]
        public void GivenInvalidFirstName_WhenAnalyze_ShouldReturnHappy()
        {
            string actual = "Sad";
            Validation user = new Validation();
            string expected = user.ValidateName("");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenInvValidLastName_WhenAnalyze_ShouldReturnHappy()
        {
            string actual = "Sad";
            Validation user = new Validation();
            string expected = user.ValidateName("");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenInvalidEmailAddress_WhenAnalyze_ShouldReturnSad()
        {
            string actual = "Sad";
            Validation user = new Validation();
            string expected = user.ValidateEmail("abcxyzblco.in");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenInValidPhoneNumber_WhenAnalyze_ShouldReturnSad()
        {
            string actual = "Sad";
            Validation user = new Validation();
            string expected = user.ValidatePhoneNumber("919738456781");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenInvalidPasswordRuleOne_WhenAnalyze_ShouldReturnSad()
        {
            string actual = "Sad";
            Validation user = new Validation();
            string expected = user.ValidatePassRuleOne("abcdefghi");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenInvalidPasswordRuleTwo_WhenAnalyze_ShouldReturnSad()
        {
            string actual = "Sad";
            Validation user = new Validation();
            string expected = user.ValidatePassRuleTwo("aasda");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenInvalidPassWordRuleThree_WhenAnalyze_ShouldReturnSad()
        {
            string actual = "Sad";
            Validation user = new Validation();
            string expected = user.ValidatePassRuleThree("Abcdfgh");
            Assert.AreEqual(actual, expected);
        }
    }
}