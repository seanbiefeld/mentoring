using CSharpKoans.Base;
using CSharpKoans.Extensions;
using NUnit.Framework;

namespace CSharpKoans
{
	public class AboutByValueAndByReference : Koans
	{
		class Person
		{
			public string Name { get; set; }
		}
	
		void ModifyPersonByValue(Person person)
		{
			person.Name = "Phillip J Fry";
			person = new Person { Name =  "Zoidberg"};
		}

		void ModifyPersonByReference(ref Person person)
		{
			person.Name = "Phillip J Fry";
			person = new Person { Name = "Zoidberg" };
		}

		[Test]
		public void ByValue()
		{
			Person person = new Person();
			
			ModifyPersonByValue(person);

			person.Name.ShouldBe(_);
		}

		[Test]
		public void ByReference()
		{
			Person person = new Person();
			
			ModifyPersonByReference(ref person);

			person.Name.ShouldBe(_);
		}
	}
}
