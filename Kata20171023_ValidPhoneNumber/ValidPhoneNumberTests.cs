using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20171023_ValidPhoneNumber
{
    [TestClass]
    public class ValidPhoneNumberTests
    {
        private Kata kata = new Kata();

        [TestMethod]
        public void input_real_phone_number()
        {
            var result = kata.ValidPhoneNumber("(123) 456-7890");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void input_not_left_brackets()
        {
            var result = kata.ValidPhoneNumber("123) 456-7890");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void input_not_right_brackets()
        {
            var result = kata.ValidPhoneNumber("(123 456-7890");
            Assert.IsFalse(result);
        }
    }

    public class Kata
    {
        public bool ValidPhoneNumber(string phoneNumber)
        {
            if (phoneNumber[0] != '(' || phoneNumber[4] != ')')
            {
                return false;
            }
            return true;
        }
    }
}