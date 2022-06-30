using System;
using Xunit;

namespace AreaCalculationLibrary.Tests;

public class TriangleTests
{
	[Fact]
	public void CalculateArea_SidesLengths3And4And5_Returns6()
	{
		var triangle = new Triangle(3, 4, 5);

		double area = triangle.CalculateArea();

		Assert.Equal(6, area);
	}

	[Fact]
	public void Constructor_NegativeLegthsOfSides_ExceptionThrowed()
	{
		Assert.Throws<ArgumentException>(() => new Triangle(-3, 4, 5));
	}

	[Fact]
	public void HalfPerimeterProperty_SidesLengths3And4And5_Equal6()
	{
		var triangle = new Triangle(3, 4, 5);

		double halfPerimeter = triangle.HalfPerimeter;

		Assert.Equal(6, halfPerimeter);
	}

	[Fact]
	public void IsRightTriangle_SidesLengths3And4And5_ReturnsTrue()
	{
		var triangle = new Triangle(3, 4, 5);

		var isRightTriangle = triangle.IsRightTriangle();

		Assert.True(isRightTriangle);
	}

	[Fact]
	public void IsRightTriangle_SidesLengths3And4And6_ReturnsFalse()
	{
		var triangle = new Triangle(3, 4, 6);

		var isRightTriangle = triangle.IsRightTriangle();

		Assert.False(isRightTriangle);
	}
}