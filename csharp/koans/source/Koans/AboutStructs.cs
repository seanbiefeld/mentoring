using CSharpKoans.Base;
using CSharpKoans.Extensions;
using NUnit.Framework;

namespace CSharpKoans
{
	public class AboutStructs : Koans
	{
		struct Point
		{
			public double x, y;
		}

		[Test]
		public void structs_allow_us_to_work_with_objects_as_a_value_type()
		{
			Point somePoint;

			//note that no Point object was instantiated with the "new" keyword
			//and we can still assign values to x and y
			somePoint.x = 21;
			somePoint.y = 42;

			somePoint.x.ShouldBe(_);
			somePoint.y.ShouldBe(_);
		}
	}
}
