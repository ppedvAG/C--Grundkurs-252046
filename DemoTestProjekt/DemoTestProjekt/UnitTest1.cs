using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DemoTestProjekt
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Assert.AreEqual(5, Calculator.Add(2, 3));
		}
	}

	public static class Calculator
	{
		public static int Add(int a, int b)
		{
			return a + b;
		}
	}
}
