using NUnit.Framework;
using UserRegistration;

namespace UserRegistrationTest
{
    public class UserEmailTest
    {
        ValidationTest validate = new ValidationTest();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("abc-100@yahoo.com")]
        [TestCase("abc@yahoo.com")]
        [TestCase("abc.100@yahoo.com")]
        [TestCase("abc111@abc.com")]
        [TestCase("abc-100@abc.net")]
        [TestCase("abc.100@abc.com.au")]
        [TestCase("abc+100@gmail.com")]
        [TestCase("abc@1.com")]

        public void GivenMultipleEmailIds_WhenValidated_ShouldReturnTrue(string email)
        {
            bool result = validate.TestEmailId(email);
            //Assert
            Assert.AreEqual(true,result);
        }

        [Test]
        [TestCase("abc")]
        [TestCase("abc@.com.my")]
        [TestCase("abc123@gmail.a")]
        [TestCase("abc123@.com")]
        [TestCase("abc123@.com.com")]
        [TestCase("abc()*@gmail.com")]
        [TestCase("abc@%*.com")]
        [TestCase("abc.@gmail.com")]

        public void GivenMultipleEmailIds_WhenValidated_ShouldReturnFalse(string email)
        {
            bool result = validate.TestEmailId(email);
            //Assert
            Assert.AreEqual(false,result);
        }
    }
}
