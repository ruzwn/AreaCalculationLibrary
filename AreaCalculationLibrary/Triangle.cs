namespace AreaCalculationLibrary;

public class Triangle : IFigure
{
	public double Side1Length { get; }
	public double Side2Length { get; }
	public double Side3Length { get; }

	public double HalfPerimeter => (Side1Length + Side2Length + Side3Length) / 2d;

	public Triangle(double side1Length, double side2Length, double side3Length)
	{
		if (side1Length < 0 || side2Length < 0 || side3Length < 0)
		{
			throw new ArgumentException("Legth of sides of triangle have to be >= 0");
		}
		
		(Side1Length, Side2Length, Side3Length) = (side1Length, side2Length, side3Length);
	}

	public double CalculateArea()
	{
		return Math.Sqrt(HalfPerimeter *
		                 (HalfPerimeter - Side1Length) *
		                 (HalfPerimeter - Side2Length) *
		                 (HalfPerimeter - Side3Length));
	}

	// Checks is it right triangle by Pifagor theorem
	public bool IsRightTriangle()
	{
		double[] squaresOfSides = {Math.Pow(Side1Length, 2), Math.Pow(Side2Length, 2), Math.Pow(Side3Length, 2)};

		return Math.Abs(squaresOfSides[0] - (squaresOfSides[1] + squaresOfSides[2])) < double.Epsilon ||
		       Math.Abs(squaresOfSides[1] - (squaresOfSides[0] + squaresOfSides[2])) < double.Epsilon ||
		       Math.Abs(squaresOfSides[2] - (squaresOfSides[0] + squaresOfSides[1])) < double.Epsilon;
	}
}