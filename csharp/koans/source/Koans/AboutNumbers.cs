using System;
using CSharpKoans.Base;
using NUnit.Framework;
using CSharpKoans.Extensions;

namespace CSharpKoans
{
	public class AboutNumbers : Koans
	{
		[Test]
		public void Infinity()
		{
			double answer = 1.0/0;

			answer.ToString().ShouldBe(_);
		}

		[Test]
		public void NotANumber()
		{
			double answer = Math.Sqrt(-1);

			answer.ToString().ShouldBe(_);
		}

		[Test]
		public void FloatingPointAndIntegerCalculation()
		{
			int someInt = 2;
			double someDouble = 2.0;

			var answer = someInt + someDouble;
			
			answer.ShouldBe(_);
		}
	}
}
