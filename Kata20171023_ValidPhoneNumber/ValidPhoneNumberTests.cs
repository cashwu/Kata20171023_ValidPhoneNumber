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
    }

    public class Kata
    {
        public bool ValidPhoneNumber(string phoneNumber)
        {
            if (!phoneNumber.StartsWith("("))
            {
                return false;
            }
            return true;
        }
    }
}