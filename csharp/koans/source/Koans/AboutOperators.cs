using CSharpKoans.Base;
using CSharpKoans.Extensions;
using NUnit.Framework;

namespace CSharpKoans
{
	public class AboutOperators : Koans
	{
		[Test]
		public void StringConcatenationWithString()
		{
			string stringPlusString = "some " + " text";

			stringPlusString.ShouldBe(_);
		}

		[Test]
		public void StringConcatenationWithChar()
		{
			string stringPlusChar = "char " + '*';

			stringPlusChar.ShouldBe(_);
		}

		[Test]
		public void StringConcatenationWithInteger()
		{
			string stringPlusInteger = "number " + 1;

			stringPlusInteger.ShouldBe(_);
		}

		[Test]
		public void StringConcatenationWithFloat()
		{
			string stringPlusFloat = "float " + 1.0;

			stringPlusFloat.ShouldBe(_);
		}

		[Test]
		public void StringConcatenationWithPlusEquals()
		{
			string someString = "the quick brown ";
			
			someString += "fox jumps";
			
			someString.ShouldBe(_);
		}

		[Test]
		public void Addition()
		{
			int answer = 2 + 2;

			answer.ShouldBe(_);
		}

		[Test]
		public void Subtraction()
		{
			int answer = 2 - 4;

			answer.ShouldBe(_);
		}

		[Test]
		public void Multiplication()
		{
			int answer = 8*8;
			
			answer.ShouldBe(_);
		}

		[Test]
		public void Division()
		{
			int answer = 49/7;

			answer.ShouldBe(_);
		}

		[Test]
		public void Modulus()
		{
			int answer = 16%4;

			answer.ShouldBe(_);
		}

		[Test]
		public void AdditionAssignment()
		{
			int answer = 0;
			
			for (int i = 0; i < 2; i++)
			{
				answer += i;
			}
			
			answer.ShouldBe(_);
		}

		[Test]
		public void SubtractionAssignment()
		{
			int answer = 14;

			for (int i = 0; i < 5; i++)
			{
				answer -= i;
			}

			answer.ShouldBe(_);
		}

		[Test]
		public void MultiplicationAssignment()
		{
			int answer = 2;

			for (int i = 0; i < 2; i++)
			{
				answer *= i;
			}

			answer.ShouldBe(_);
		}

		[Test]
		public void DivisionAssignment()
		{
			int answer = 16;

			for (int i = 0; i < 2; i++)
			{
				answer /= i;
			}

			answer.ShouldBe(_);
		}

		[Test]
		public void AdditionAssignmentShorthand()
		{
			int answer = 1;

			for (int i = 0; i < 2; i++)
			{
				answer++;
			}

			answer.ShouldBe(_);
		}

		[Test]
		public void SubtractionAssignmentShorthand()
		{
			int answer = 5;

			for (int i = 0; i < 2; i++)
			{
				answer--;
			}

			answer.ShouldBe(_);
		}

		[Test]
		public void EqualSignString()
		{
			bool areEqual = "asdf" == "asdF";

			areEqual.ShouldBe(_);
		}

		[Test]
		public void EqualSignNumbers()
		{
			bool areEqual = 1 == 1.0;

			areEqual.ShouldBe(_);
		}

		[Test]
		public void EqualSignObjects()
		{
			object a = new { foo = "foo" };
			object b = new { foo = "foo" };

			bool areEqual = a == b;

			areEqual.ShouldBe(_);
		}

		[Test]
		public void DotEqualsObjects()
		{
			object a = new { foo = "foo" };
			object b = new { foo = "foo" };

			bool areEqual = a.Equals(b);

			areEqual.ShouldBe(_);
		}

		[Test]
		public void StringsNotEqualSign()
		{
			bool areEqual = "asdf" != "asDf";

			areEqual.ShouldBe(_);
		}

		[Test]
		public void ObjectsNotEqualSign()
		{
			object a = new { foo = "foo" };
			object b = new { foo = "foo" };

			bool areEqual = a != b;

			areEqual.ShouldBe(_);
		}

		[Test]
		public void BooleanNotEqualSign()
		{
			bool areEqual = !false;

			areEqual.ShouldBe(_);
		}

		[Test]
		public void LessThan()
		{
			bool isLessThan = 5 < 6;

			isLessThan.ShouldBe(_);
		}

		[Test]
		public void GreaterThan()
		{
			bool isLessThan = 4 > 5;

			isLessThan.ShouldBe(_);
		}

		[Test]
		public void LessThanOrEqualTo()
		{
			bool isLessThan = 5 <= 6;

			isLessThan.ShouldBe(_);
		}

		[Test]
		public void GreaterThanOrEqualTo()
		{
			bool isLessThan = 4 >= 4.0;

			isLessThan.ShouldBe(_);
		}

		[Test]
		public void ConditionalAnd()
		{
			bool someBool = true && false ;
			
			someBool.ShouldBe(_);
		}

		[Test]
		public void ConditionalOr()
		{
			bool someBool = false || true;

			someBool.ShouldBe(_);
		}

		class nullCoalescingClass{}

		[Test]
		public void NullCoalescing()
		{
			nullCoalescingClass nullCoaliescingObject = null;
			
			nullCoalescingClass anotherNullCoaliescingObject = nullCoaliescingObject ?? new nullCoalescingClass();

			var isNull = anotherNullCoaliescingObject == null;
			
			isNull.ShouldBe(_);
		}

		[Test]
		public void TernaryOperator()
		{
			string beginning = "hola";

			string message = (beginning == "hello") ? beginning : "good bye";
			
			message.ShouldBe(_);
		}
	}
}
