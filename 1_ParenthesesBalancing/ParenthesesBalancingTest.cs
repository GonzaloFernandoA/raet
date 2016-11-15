using NUnit.Framework;

namespace ParenthesesBalancing
{
  [TestFixture]
  public class ParenthesesBalancingTest
  {
      [Test]
      public void givenEmptyText_whenIsBalanced_thenReturnTrue()
      {
          Assert.IsTrue(new ParenthesesBalancing().IsBalanced(""));
      }

    [Test]
    public void givenTextWithoutParentheses_whenIsBalanced_thenReturnTrue()
    {
      Assert.IsTrue(new ParenthesesBalancing().IsBalanced("this does not contain any parentheses"));
    }

    [Test]
    public void givenTextWithBalancedParentheses_whenIsBalanced_thenReturnTrue()
    {
      const string maryAndHerPuppy = "Mary (poor dear) lost her puppy (which she loved so much).";
      Assert.IsTrue(new ParenthesesBalancing().IsBalanced(maryAndHerPuppy));
    }

    [Test]
    public void givenTextWithUnBalancedLeftParentheses_whenIsBalanced_thenReturnFalse()
    {
      const string unfinishedEquation = "(a + b - (c * d)";
      Assert.IsFalse(new ParenthesesBalancing().IsBalanced(unfinishedEquation));
    }

    [Test]
    public void givenTextWithUnBalancedRightParentheses_whenIsBalanced_thenReturnFalse()
    {
      const string unfinishedEquation = "a + b - (c * d))";
      Assert.IsFalse(new ParenthesesBalancing().IsBalanced(unfinishedEquation));
    }

    [Test]
    public void givenComplicatedTextWithBalancedParentheses_whenIsBalanced_thenReturnTrue()
    {
      const string weirdText = "d('')b + ((a :-) - b :-( =)) ";
      Assert.IsTrue(new ParenthesesBalancing().IsBalanced(weirdText));
    }

    [Test]
    public void givenComplicatedTextWithUnnBalancedParentheses_whenIsBalanced_thenReturnFalse()
    {
        const string weirdText = "d)(('')b + ((a :-) - b :-( =)) ";
        Assert.IsFalse(new ParenthesesBalancing().IsBalanced(weirdText));
    }
  }
}
