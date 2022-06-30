using System;
using Xunit;

namespace AreaCalculationLibrary.Tests;

public class CircleTests
{
	[Fact]
	public void CalculateArea_Radius5_Returns85()
	{
		var circle = new Circle(5);

		double area = circle.CalculateArea();

		Assert.Equal(area, Math.PI * Math.Pow(5, 2));
	}

	[Fact]
	public void Constructor_RadiusNegative_ExceptionThrowed()
	{
		Assert.Throws<ArgumentException>(() => new Circle(-5));
	}
}