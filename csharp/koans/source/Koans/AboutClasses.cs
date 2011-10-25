using System;
using CSharpKoans.Base;
using CSharpKoans.Extensions;
using NUnit.Framework;

namespace CSharpKoans
{
	public class AboutClasses : Koans
	{
		//class
		class Person
		{
			//fields
			readonly string _hairColor;
			readonly DateTime _dateOfBirth;

			//constructor
			public Person(string hairColor, DateTime dateOfBirth)
			{
				_hairColor = hairColor;
				_dateOfBirth = dateOfBirth;
			}

			//property
			public string HairColor
			{
				get { return _hairColor; }
			}
			
			//method
			public int GetAge()
			{
				var now = DateTime.Now;
				int age = now.Year - _dateOfBirth.Year;
				if (now.Month < _dateOfBirth.Month || (now.Month == _dateOfBirth.Month && now.Day < _dateOfBirth.Day)) age--;
				return age;
			}
		}

		[Test]
		//Classes describe real world objects
		//they contain information about those objects
		//and describe behaviors of those objects
		public void Classes_describe_real_world_objects()
		{
			Person person = new Person("brown", new DateTime(1984, 05, 04));

			person.HairColor.ShouldBe(_);
			
			person.GetAge().ShouldBe(_);
		}
	}
}
