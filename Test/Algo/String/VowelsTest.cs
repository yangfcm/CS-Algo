using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.String;

namespace Test.Algo.String
{
  public class VowelsTest
  {
    [TestMethod]
    [DataRow("apple", 2)]
    [DataRow("John SMITH", 2)]
    [DataRow("why?", 0)]
    public void TestVowels(string str, int expectedVowelsNum)
    {
      int vowelsNum = Vowels.Run(str);
      Assert.AreEqual(vowelsNum, expectedVowelsNum);
    }
  }
}