using CSharpKoans.Base;
using CSharpKoans.Extensions;
using NUnit.Framework;

namespace CSharpKoans
{
	/// <summary>
	/// encapsulation is used in object oriented programming
	/// to allow objects to manipulate themselves while
	/// disallowing other objects to manipulate them in the same way
	/// objects can be extended but their internals cannot be modified
	/// the objects maintain sovereignty over themselves
	/// </summary>
	public class AboutEncapsulation : Koans
	{
		abstract class Automobile
		{
			protected int _milesDriven;
			
			public int MilesDriven
			{
				get { return _milesDriven; }
			}

			public Automobile()
			{
				_milesDriven = 0;
			}
			
			public void Drive(int numberOfMilesToDrive)
			{
				_milesDriven += numberOfMilesToDrive;
			}
		}
		
		class Car : Automobile
		{
			public void ReplaceEngine()
			{
				_milesDriven = 0;
			}
		}

		[Test]
		// the Automobile encapuslates the behavior of driving and
		// incrementing the total number of miles driven
		// miles driven can be increased by driving the car
		// but it cannot be decreased or manipulated in any other way
		public void the_car_encapusulates_the_incrementing_of_miles()
		{
			Car car = new Car();
			
			car.Drive(1000);

			car.MilesDriven.ShouldBe(_);
		}

		[Test]
		// the automobile can be extended with a replaceEngine method on the car
		// _milesDriven can be manipulated by car only because car inherits automobile
		// _milesDriven can still not be modified drirectly
		public void the_automobile_can_be_extended()
		{
			Car car = new Car();
			
			car.Drive(1000);
			
			car.ReplaceEngine();
			
			car.MilesDriven.ShouldBe(_);
		}
	}
}
