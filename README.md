# ColorMinePortable for MAUI

This is the extensions that it made ColorMinePortable(https://github.com/muak/ColorMinePortable) correspond to MAUI.

## Nuget Installation

```bash
Install-Package ColorMinePortable.Maui
```

## Maui Conversion

```csharp
var xcolor = Colors.Red;
var rgb = xcolor.To<Rgb>(); //Maui to ColorMine Rgb
var xcolor2 = rgb.ToMaui(); // ColorMine Rgb to MAUI
```

## Dependency

* ColorMinePortable
