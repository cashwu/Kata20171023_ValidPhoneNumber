using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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

        [TestMethod]
        public void input_not_three_number_in_brackets()
        {
            var result = kata.ValidPhoneNumber("(aaa) 456-7890");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void input_not_dash()
        {
            var result = kata.ValidPhoneNumber("(123) 456 7890");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void input_not_three_number_in_middle()
        {
            var result = kata.ValidPhoneNumber("(123) aaa-7890");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void input_not_white_space_in_right_brackets()
        {
            var result = kata.ValidPhoneNumber("(123)-123-7890");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void input_not_four_number_in_end()
        {
            var result = kata.ValidPhoneNumber("(123) 123-aaaa");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void input_more_than_ten_number()
        {
            var result = kata.ValidPhoneNumber("(123) 123-45642");
            Assert.IsFalse(result);
        }
    }

    public class Kata
    {
        public bool ValidPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length != 14
                || phoneNumber[0] != '('
                || !phoneNumber.Substring(1, 3).All(a => int.TryParse(a.ToString(), out var b))
                || phoneNumber[4] != ')'
                || phoneNumber[5] != ' '
                || !phoneNumber.Substring(6, 3).All(a => int.TryParse(a.ToString(), out var b))
                || phoneNumber[9] != '-'
                || !phoneNumber.Substring(10, 4).All(a => int.TryParse(a.ToString(), out var b)))
            {
                return false;
            }
            return true;
        }
    }
}