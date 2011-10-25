using System.Collections.Generic;
using CSharpKoans.Base;
using CSharpKoans.Extensions;
using NUnit.Framework;

namespace CSharpKoans
{
	/// <summary>
	/// Iheritance is pretty straight forward
	/// child objects inherit behaviors and information from their parents
	/// the colon : after the class name is used to specify inheritance
	/// </summary>
	public class AboutInheritance : Koans
	{
		abstract class Person
		{
			public bool HasEaten;
			public bool HasWalked;
			
			public void Eat()
			{
				HasEaten = true;
			}
		}
		
		class Adult : Person
		{
			public void Walk()
			{
				HasWalked = true;
			}
		}

		class Baby : Person
		{
			
		}

		[Test]
		public void an_adult_has_everything_a_person_has_plus_walking_and_talking()
		{
			Adult adult = new Adult();
			
			Baby baby = new Baby();
			
			IList<Person> people = new List<Person>
			{
				adult,
				baby
			};
			
			// note: both the baby and adult can eat
			foreach (var person in people)
			{
				person.Eat();
			}
			
			// note: only the adult can walk which will set has walked to true
			adult.Walk();
			
			adult.HasWalked.ShouldBe(_);
			
			// note: because the baby inherits person we can still access HasWalked
			baby.HasWalked.ShouldBe(_);
			
			// note: both the baby and adult have eaten
			adult.HasEaten.ShouldBe(_);
			baby.HasEaten.ShouldBe(_);
		}
	}
}
