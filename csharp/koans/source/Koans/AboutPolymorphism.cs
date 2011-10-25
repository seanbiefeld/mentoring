using System;
using System.Collections.Generic;
using CSharpKoans.Base;
using CSharpKoans.Extensions;
using NUnit.Framework;

namespace CSharpKoans
{
	/// <summary>
	/// polymorphism occurs when objects take on multiple forms
	/// in this example an animal can be a cat or a dog
	/// no matter which it is we can tell it to speak
	/// </summary>
	public class AboutPolymorphism : Koans
	{
		abstract class Animal
		{
			public string Name { get; private set; }

			public abstract string Speak();

			protected Animal(string name)
			{
				Name = name;
			}
		}

		class Cat : Animal
		{
			public Cat(string name)
				: base(name)
			{
			}

			public override string Speak()
			{
				return "Meowww!";
			}
		}

		class Dog : Animal
		{
			public Dog(string name)
				: base(name)
			{
			}

			public override string Speak()
			{
				return "Woof! Woof!";
			}
		}

		[Test]
		public void make_the_animals_speak()
		{
			Dog dogOne = new Dog("Sparky");
			Cat catOne = new Cat("Mr. Bigglesworth");
			Dog dogTwo = new Dog("Zoidberg");
			Cat catTwo = new Cat("Farnsworth");
			
			IList<Animal> animals = new List<Animal>{ dogOne, catOne, catTwo, dogTwo };

			string whatTheAnimalsSay = string.Empty;

			var count = 0;
			foreach (var animal in animals)
			{
				var leadingCharacter = (count == 0) ? string.Empty : " - ";
				
				whatTheAnimalsSay += leadingCharacter + animal.Name + " says " + animal.Speak();

				count++;
			}

			whatTheAnimalsSay.ShouldBe(_);
		}
	}
}
