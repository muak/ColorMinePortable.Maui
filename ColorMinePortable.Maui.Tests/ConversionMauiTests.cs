using ColorMine.ColorSpaces;
using NUnit.Framework;

namespace ColorMine.Tests.ColorSpaces;

[TestFixture]
public class MauiTest
{
	private double diff = 0.01;
		
	[Test]
	public void WhiteMauiToRgb()
	{
		var knownColor = Colors.White;
		var expectedColor = new Rgb { R = 255, G = 255, B = 255, };

		var conv = knownColor.To<Rgb>();
		(conv.R - expectedColor.R < diff).IsTrue();
		(conv.G - expectedColor.G < diff).IsTrue();
		(conv.B - expectedColor.B < diff).IsTrue();
	}
	[Test]
	public void GoldenrodMauiToRgb()
	{
		var knownColor = Color.FromRgb(218, 165, 32);
		var expectedColor = new Rgb { R = 218, G = 165, B = 32, };

		var conv = knownColor.To<Rgb>();
		(conv.R - expectedColor.R < diff).IsTrue();
		(conv.G - expectedColor.G < diff).IsTrue();
		(conv.B - expectedColor.B < diff).IsTrue();
	}
	[Test]
	public void MaroonMauiToRgb()
	{
		var knownColor = Colors.Maroon;
		var expectedColor = new Rgb { R = 128, G = 0, B = 0 };

		var conv = knownColor.To<Rgb>();
		(conv.R - expectedColor.R < diff).IsTrue();
		(conv.G - expectedColor.G < diff).IsTrue();
		(conv.B - expectedColor.B < diff).IsTrue();
	}

}
