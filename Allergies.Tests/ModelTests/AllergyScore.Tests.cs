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
      List<int> binaryList = Score.ConvertToBinary(13);
      List<int> testList = {1, 0, 0};
      Assert.AreEqual(testList, binaryList);
    }
  }
}