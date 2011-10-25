using System;
using CSharpKoans.Base;
using CSharpKoans.Extensions;
using NUnit.Framework;

namespace CSharpKoans
{
	public class AboutEnums : Koans
	{
		//note enums help provide a type with distinct constants
		enum Colors
		{
			Red,
			Blue,
			Yellow
		}

		[Test]
		public void enums_have_an_underlying_type_of_integer_by_default()
		{
			((int)Colors.Red == 0).ShouldBe(_);
			((int)Colors.Blue == 1).ShouldBe(_);
			((int)Colors.Yellow == 2).ShouldBe(_);
		}

		[Test]
		public void enums_can_be_used_in_switch_statements()
		{
			var someColor = Colors.Blue;
			var chosenColor = string.Empty;
			
			switch(someColor)
			{
				case Colors.Red:
					chosenColor = "i chose red";
					break;
				case Colors.Blue:
					chosenColor = "i chose blue";
					break;
				case Colors.Yellow:
					chosenColor = "i chose yellow";
					break;
			}

			chosenColor.ShouldBe(_);
		}

		[Test]
		public void the_Enum_class_can_be_used_to_obtain_an_enums_name()
		{
			string enumName = Enum.GetName(typeof(Colors), Colors.Blue);
			enumName.ShouldBe(_);
		}

		[Test]
		public void the_Enum_class_allows_us_to_enumerate_over_the_enums_names()
		{
			var names = string.Empty;
		
			foreach (var name in Enum.GetNames(typeof(Colors)))
			{
				names += name + " ";
			}
			
			names.ShouldBe(_);
		}

		[Test]
		public void the_Enum_class_allows_us_to_enumerate_over_the_enums_values()
		{
			var valueSum = 0;

			foreach (var value in Enum.GetValues(typeof(Colors)))
			{
				valueSum += (int)value;
			}

			valueSum.ShouldBe(_);
		}

		[Flags]
		enum CarOptions
		{
			MoonRoof = 0x01,
			Spoiler = 0x02,
			FogLights = 0x04,
			TintedWindows = 0x08
		}

		[Test]
		public void enums_can_be_used_as_flags()
		{
			var myOptions = CarOptions.MoonRoof | CarOptions.FogLights;

			var someOtherOptions = CarOptions.Spoiler | CarOptions.TintedWindows;

			myOptions.ToString().ShouldBe(_);
			someOtherOptions.ToString().ShouldBe(_);
		}
	}
}
