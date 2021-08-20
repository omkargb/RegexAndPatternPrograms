using NUnit.Framework;
using UserRegistration;

namespace UserRegistrationTest
{
    public class Tests
    {
        ValidationTest validate = new ValidationTest();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenFirstName_WhenValidated_ShouldReturnHappy()
        {
            string firstName = "Abcd";
            bool result = validate.TestFirstName(firstName);
            Assert.AreEqual(true, result);
            Assert.Pass();
        }

        [Test]
        public void GivenFirstName_WhenNotValidated_ShouldReturnSad()
        {
            string firstName = "abcd4";
            bool result = validate.TestFirstName(firstName);
            Assert.AreEqual(false, result);
            Assert.Pass();
        }

        [Test]
        public void GivenLastName_WhenValidated_ShouldReturnHappy()
        {
            string lastName = "Roy";
            bool result = validate.TestLastName(lastName);
            Assert.AreEqual(true, result);
            Assert.Pass();
        }

        [Test]
        public void GivenLastName_WhenNotValidated_ShouldReturnSad()
        {
            string lastName = "roy";
            bool result = validate.TestLastName(lastName);
            Assert.AreEqual(false, result);
            Assert.Pass();
        }

        [Test]
        public void GivenMobileNumber_WhenValidated_ShouldReturnHappy()
        {
            string mobile = "91 9874563210";
            bool result = validate.TestMobileNum(mobile);
            Assert.AreEqual(true, result);
            Assert.Pass();
        }

        [Test]
        public void GivenMobileNumber_WhenNotValidated_ShouldReturnSad()
        {
            string mobile = "9123654789";
            bool result = validate.TestMobileNum(mobile);
            Assert.AreEqual(false, result);
            Assert.Pass();
        }
        
        [Test]
        public void GivenPassword_WhenValidated_ShouldReturnHappy()
        {
            string password1 = "ABxyz@13579";
            bool result = validate.TestPassword(password1);
            Assert.AreEqual(true, result);
            Assert.Pass();
        }

        [Test]
        public void GivenPassword_WhenNotValidated_ShouldReturnSad()
        {
            string password2 = "1234";
            bool result = validate.TestPassword(password2);
            Assert.AreEqual(false, result);
            Assert.Pass();
        }
                
        [Test]
        public void GivenEmailId_WhenValidated_ShouldReturnHappy()
        {
            string emailid1 = "abc.100@yahoo.com";
            bool result = validate.TestEmailId(emailid1);
            Assert.AreEqual(true, result);
            Assert.Pass();
        }

        [Test]
        public void GivenEmailId_WhenNotValidated_ShouldReturnSad()
        {
            string emailid2 = "abc@k%*.com";
            bool result = validate.TestEmailId(emailid2);
            Assert.AreEqual(false, result);
            Assert.Pass();
        }

    }
}