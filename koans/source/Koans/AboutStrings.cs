using CSharpKoans.Base;
using CSharpKoans.Extensions;
using NUnit.Framework;

namespace CSharpKoans
{
	public class AboutStrings : Koans
	{
		[Test]
		public void Assignment()
		{
			string text = "some text";
			
			text.ShouldBe(_);
		}

		[Test]
		public void Length()
		{
			string someString = "hello world";
			
			someString.Length.ShouldBe(_);
		}

		[Test]
		public void AsArray()
		{
			string someString = "the quick brown fox";
			
			someString[5].ShouldBe(_);
		}

		[Test]
		public void Substring()
		{
			string someString = "the quick brown fox";
			
			someString.Substring(5,2).ShouldBe(_);
		}

		[Test]
		public void IndexOf()
		{
			string someString = "get the index of x in this string";
			
			someString.IndexOf('x').ShouldBe(_);
		}

		[Test]
		public void IndexOfAny()
		{
			string someString = "get the index of x in this string";
			
			someString.IndexOfAny(new[] {'x','y'}).ShouldBe(_);
		}

		[Test]
		public void Insert()
		{
			string someString = "hello orld";
			
			//write code using the insert method to add the missing w
			
			someString.ShouldBe("hello world");
		}

		[Test]
		public void Remove()
		{
			string someString = "the quick brown fox fox runs";

			//write some code to remove the extra fox and space in the string

			someString.ShouldBe("the quick brown fox runs");
		}

		[Test]
		public void Replace()
		{
			string someString = "some,string,to,replace,stuff,in";

			someString = someString.Replace(',', ' ');
			
			someString.ShouldBe(_);
		}

		[Test]
		public void Trim()
		{
			string stringToTrim = "     why are there spaces around me  ";
			
			stringToTrim = stringToTrim.Trim();
			
			stringToTrim.ShouldBe(_);
		}

		[Test]
		public void Split()
		{
			string stringToSplit = "phillip j fry";
			
			string[] splitStrings = stringToSplit.Split(' ');
			
			splitStrings.ShouldBe(new[] {_,_,_});
		}

		[Test]
		public void EscapeCharacters()
		{
			string someString = "some \"thing\" \\ has \'escaped\'";

			someString.ShouldBe(_);
		}

		[Test]
		public void AtSymbol()
		{
			string someString = @"C:\good\for\file\paths";
			
			someString.ShouldBe(_);
		}

		[Test]
		public void ToUpper()
		{
			string someString = "some STRing".ToUpper();

			someString.ShouldBe(_);
		}

		[Test]
		public void ToLower()
		{
			string someString = "some STRing".ToLower();

			someString.ShouldBe(_);
		}
	}
}
