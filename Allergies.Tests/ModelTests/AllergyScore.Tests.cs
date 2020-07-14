using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllergyScore;

namespace AllergyScore.Tests
{
  [TestClass]
  public class ScoreTests
  {
    [TestMethod]
    public void ConvertToBinary_ConvertingInputToBinary_ListOfOnesAndZeros()
    {
      Score.ConvertToBinary(13);
      Assert.AreEqual();
    }
  }
}