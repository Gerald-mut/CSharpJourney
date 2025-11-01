// File: PalindromeService.Tests/StringServiceTests.cs
using Xunit;
using PalindromeService; // <-- This is your app's code!

namespace PalindromeService.Tests
{
    public class StringServiceTests
    {
        [Fact]
        public void IsPalindrome_ShouldReturnTrueForPalindrome()
        {
            // Arrange
            // TODO: Create an instance of your StringService
            StringService stringserv = new StringService();
            // TODO: Create a test string (e.g., "A man, a plan, a canal: Panama")
            string a = "A man, a plan, a canal: Panama";


            // Act
            
            // TODO: Call the IsPalindrome method

            // Assert
            // TODO: Assert that the result is 'true'
            Assert.True(false); // Replace this!
        }
    }
}