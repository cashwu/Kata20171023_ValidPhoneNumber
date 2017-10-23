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
    }

    public class Kata
    {
        public bool ValidPhoneNumber(string phoneNumber)
        {
            return true;
        }
    }
}