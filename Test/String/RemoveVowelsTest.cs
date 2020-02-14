using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo;

namespace Test
{

	[TestClass]
	public class RemoveVowelsTest
	{
		[TestMethod]
		[DataRow("I love apples and bananas", " lv ppls nd bnns")]
		public void TestSolution(string str, string expectedStr)
		{
			var result = RemoveVowels.Run(str);
			Assert.AreEqual(result, expectedStr);
		}
	}
}