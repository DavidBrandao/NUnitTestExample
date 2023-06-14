using NUnit.Framework;

namespace ByteBankAppTest
{
    public class TestPassword
    {
        [Test]
        public void PasswordRight()
        {
            var password = "LwUzf6z8aTcFky$";
            Assert.True(Password.IsValidPassword2(password));
        }

        [Test]
        public void PasswordLengthIncorrect()
        {
            var password = "fZ*6Z&Fq";
            Assert.False(Password.IsValidPassword2(password));
        }

        [Test]
        public void PasswordWithoutUpperCase()
        {
            var password = "6c%06jy*yv7y*";
            Assert.False(Password.IsValidPassword2(password));
        }

        [Test]
        public void PasswordWithoutLowerCase()
        {
            var password = "QGRT@9WOSNHTK";
            Assert.False(Password.IsValidPassword2(password));
        }

        [Test]
        public void PasswordWithoutDigits()
        {
            var password = "aO#VqE^MJbfJl";
            Assert.False(Password.IsValidPassword2(password));
        }

        [Test]
        public void PasswordWithoutSpecialCharacters()
        {
            var password = "MdW8ldKhPnP94";
            Assert.False(Password.IsValidPassword2(password));
        }
    }
}