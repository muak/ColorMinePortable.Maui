using System;
using Microsoft.Maui.Graphics;

namespace ColorMine.ColorSpaces;

public static class MauiColorExtension
{
    /// <summary>
    /// Convert Xamarin.Forms.Color to any IColorSpace
    /// </summary>
    /// <param name="color"></param>
    /// <typeparam name="T">IColorSpace</typeparam>
    public static T To<T>(this Color color) where T : IColorSpace, new()
    {
        var rgb = new Rgb {
            R = color.Red * 255,
            G = color.Green * 255,
            B = color.Blue * 255,
        };
        return rgb.To<T>();
    }

    /// <summary>
    /// Convert any IColorSpace to Xamarin.Forms.Color
    /// </summary>
    /// <returns>Xamarin.Forms.Color</returns>
    /// <param name="color"></param>
    public static Color ToMaui(this IColorSpace color)
    {
        var rgb = color.ToRgb();
        return Color.FromRgb(
            (int)Math.Round(rgb.R, 0),
            (int)Math.Round(rgb.G, 0),
            (int)Math.Round(rgb.B, 0)
        );
    }
}

