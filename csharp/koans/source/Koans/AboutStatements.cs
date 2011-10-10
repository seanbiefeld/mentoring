using CSharpKoans.Base;
using CSharpKoans.Extensions;
using NUnit.Framework;

namespace CSharpKoans
{
	public class AboutStatements : Koans
	{
		[Test]
		public void IfElse()
		{
			string message = "none";
			
			if(message.IndexOf('o') > -1)
				message = "hello";
			else
				message = "good bye";

			message.ShouldBe(_);
		}

		[Test]
		public void IfElseIfElse()
		{
			string message = "none";

			if (message.IndexOf('i') > -1)
				message = "hello";
			else if(message.IndexOf('n') > -1)
				message = "hmmm";
			else
				message = "good bye";

			message.ShouldBe(_);
		}

		[Test]
		public void Switch()
		{
			string message = string.Empty;
			string[] someArray = new[] { "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };

			for (int i = 0; i < someArray.Length; i++)
			{
				switch (someArray[i])
				{
					case "fox" :
						{
							message += "hello fox ";
							break;
						}
					case "cat":
						{
							message += "hello cat ";
							break;
						}
					case "dog":
						{
							message += "hello dog ";
							break;
						}
					default:
						{
							message += "-";
							break;
						}
				}
			}
			
			message.ShouldBe(_);
		}

		[Test]
		public void ForLoopIncreasing()
		{
			int count = 0;
		
			for (int i = 1; i < 5; i++)
			{
				count++;
			}
			
			count.ShouldBe(_);	
		}

		[Test]
		public void ForLoopDecreasing()
		{
			int count = 0;

			for (int i = 10; i > 5; i--)
			{
				count++;
			}

			count.ShouldBe(_);
		}

		[Test]
		public void WhileLoop()
		{
			int count = 0;

			bool continueLoop = true;

			while (continueLoop)
			{
				count++;
				
				if(count == 20)
					continueLoop = false;
			}
			
			count.ShouldBe(_);
		}

		[Test]
		public void DoWhileLoop()
		{
			int count = 0;

			bool continueLoop = true;

			do
			{
				count++;

				if (count == 10)
					continueLoop = false;
			}
			while (continueLoop);

			count.ShouldBe(_);
		}

		[Test]
		public void ForEach()
		{
			string[] someArray = new[] { "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };

			string results = string.Empty;

			foreach (var item in someArray)
			{
				if(item.Contains("o"))
					results += item + " ";
			}
				
			results.ShouldBe(_);
		}
	}
}
