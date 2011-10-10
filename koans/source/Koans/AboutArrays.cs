using System;
using CSharpKoans.Base;
using CSharpKoans.Extensions;
using NUnit.Framework;

namespace CSharpKoans
{
	public class AboutArrays : Koans
	{
		[Test]
		public void Length()
		{
			int arrayLength = new int[4].Length;
				
			arrayLength.ShouldBe(_);
		}
	
		[Test]
		public void Assignment()
		{
			string[] stringArray = new string[10];

			for (int i = 0; i < stringArray.Length; i++)
			{
				stringArray[i] = (i+i).ToString();
			}
			
			stringArray[5].ShouldBe(_);
		}

		[Test]
		public void ResizingArray()
		{
			string[] someArray = new[]{ "the", "quick", "brown"};

			Array.Resize(ref someArray, someArray.Length + 1);
			someArray[3] = "fox";

			Array.Resize(ref someArray, someArray.Length + 1);
			someArray[4] = "jumps";
			
			someArray.Length.ShouldBe(_);
		}

		[Test]
		public void IndexOf()
		{
			string[] someArray = new[] { "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };

			int index = Array.IndexOf(someArray, "fox");
			
			index.ShouldBe(_);
		}

		[Test]
		public void Sort()
		{
			string[] someArray = new[] { "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };

			Array.Sort(someArray);

			someArray[4].ShouldBe(_);
		}

		[Test]
		public void Copy()
		{
			string[] someArray = new[] { "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };

			string[] someOtherArray = new string[someArray.Length];
			
			someArray.CopyTo(someOtherArray,0);

			someOtherArray[4].ShouldBe(_);
		}

		[Test]
		public void Reverse()
		{
			string[] someArray = new[] { "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };

			Array.Reverse(someArray);

			someArray[2].ShouldBe(_);
		}

		[Test]
		public void MultiDimensionArray()
		{
			int[,] multiArray = new int[2,3];

			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					multiArray[i, j] = j*3;
				}
			}
			
			multiArray[1,0].ShouldBe(_);
		}

	}
}
