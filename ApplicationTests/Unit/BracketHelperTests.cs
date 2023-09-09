using Application.Helpers;

namespace ApplicationTests.Unit
{
    public class BracketHelperTests
    {
        [Theory]
        [InlineData("(){}[]")]
        [InlineData("[{()}](){}")]
        [InlineData("")]
        [InlineData("{[()]}")]
        [InlineData("{{[[(())]]}}")]
        public void IsBalancedMustReturnTrueWithValidInput(string input)
        {
            bool result = BracketHelper.IsBalanced(input);

            Assert.True(result);
        }

        [Theory]
        [InlineData("[]{()")]
        [InlineData("[{)]")]
        [InlineData("{[(])}")]
        [InlineData("{}]")]
        public void IsBalancedMustReturnFalseWithInvalidInput(string input)
        {
            bool result = BracketHelper.IsBalanced(input);

            Assert.False(result);
        }
    }
}