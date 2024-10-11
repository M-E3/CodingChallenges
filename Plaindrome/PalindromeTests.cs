using PalindromeChecker;

namespace PalindromeTests
{
    public class PalindromeTests
    {

        [Test]
        public void CheckStringTestShouldReturnTrue()
        {
            //Arrange
            IsPalindrome sut = new IsPalindrome();

            //Act
            var isPalindrome = sut.CheckString("A man, a plan, a canal: Panama");
            var isNotPalindrome = sut.CheckString("Hello World");
            var isAlsoPalindrome = sut.CheckString("Ra!cecar44");

            //Assert
            Assert.Multiple(() =>
            {
                Assert.IsTrue(isPalindrome);
                Assert.IsFalse(isNotPalindrome);
                Assert.IsTrue(isAlsoPalindrome);

            });
        }
    }
}