using System;
using System.Collections.Generic;
using CSharpKoans.Base;
using CSharpKoans.Extensions;
using NUnit.Framework;

namespace CSharpKoans
{
	public class AboutInterfaces : Koans
	{
		interface IShape
		{
			double Area();
		}
	
		class Circle : IShape
		{
			readonly double _radius;

			public Circle(double radius)
			{
				_radius = radius;
			}

			public double Area()
			{
				return Math.PI * Math.Pow(_radius, 2);
			}
		}

		class Rectangle : IShape
		{
			readonly double _length;
			readonly double _width;

			public Rectangle(double length, double width)
			{
				_length = length;
				_width = width;
			}

			public double Area()
			{
				return _length * _width;
			}
		}

		[Test]
		public void Interfaces_provide_an_abstraction_of_information_among_like_objects()
		{
			//we can work with collections of objects that implement the same interface
			IShape[] shapes = new IShape[] { new Circle(21), new Rectangle(42,21)};
			
			IList<double> areas = new List<double>();

			//we dont care what shape is in the collection
			//nor do we care how the Area() method is implemented
			//we can get the area of any type of shape
			foreach (var shape in shapes)
			{
				areas.Add(shape.Area());
			}
			
			//the area of the cirlce
			areas[0].ShouldBe(_);
			
			//the area of the rectangle
			areas[1].ShouldBe(_);
		}
	}
}
