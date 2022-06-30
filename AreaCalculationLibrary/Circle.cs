namespace AreaCalculationLibrary;

public class Circle : IFigure
{
	public double Radius { get; }

	public Circle(double radius)
	{
		if (radius < 0)
		{
			throw new ArgumentException("Radius of circle have to be >= 0");
		}
		
		Radius = radius;
	}
	
	public double CalculateArea()
	{
		return Math.PI * Math.Pow(Radius, 2);
	}
}