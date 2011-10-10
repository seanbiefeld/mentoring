using CSharpKoans.Base;
using CSharpKoans.Extensions;
using NUnit.Framework;

namespace CSharpKoans
{
	public class AboutModifiers : Koans
	{
		class Foo
		{
			static int fooCount;
		
			public const int number = 42;

			public readonly string message = "hello";
		
			public Foo()
			{
				fooCount++;
				message = "adios";
			}
		
			public static int GetFooCount()
			{
				return fooCount;
			}
		}
	
		[Test]
		public void Static()
		{
			Foo foo = new Foo();	
			Foo otherFoo= new Foo();	
			Foo anotherFoo = new Foo();

			//note that none of the instances are used to get the foo count
			//an instance is not required for a static member
			Foo.GetFooCount().ShouldBe(_);
		}

		[Test]
		public void Const()
		{
			//note an isntance is not required to access a constant
			Foo.number.ShouldBe(_);
		}

		[Test]
		public void ReadOnly()
		{
			Foo foo = new Foo();
			
			//note an instance is need for a readonly
			foo.message.ShouldBe(_);
		}
	}
}
