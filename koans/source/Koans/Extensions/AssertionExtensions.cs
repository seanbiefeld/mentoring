using NUnit.Framework;

namespace CSharpKoans.Extensions
{
	public static class AssertionExtensions
	{
		public static void ShouldBe<T>(this T expected, T actual)
		{
			Assert.AreEqual(expected,actual);
		}
	}
}