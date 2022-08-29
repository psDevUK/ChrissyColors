using System;
using System.Drawing;
using System.Management.Automation;
using RandomColorGenerator;
namespace ChrissyColors
{
    [Cmdlet(VerbsLifecycle.Invoke, "ChrissyColors")]
    public class Chrissy : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        public int NumberOfResults { get; set; }
        protected override void EndProcessing()
        {
            var BlueLight = RandomColor.GetColors(ColorScheme.Blue, Luminosity.Light, NumberOfResults);
            var BlueDark = RandomColor.GetColors(ColorScheme.Blue, Luminosity.Dark, NumberOfResults);
            var BlueBright = RandomColor.GetColors(ColorScheme.Blue, Luminosity.Bright, NumberOfResults);
            WriteObject(BlueBright);
            WriteObject(BlueDark);
            WriteObject(BlueLight);
            var GreenLight = RandomColor.GetColors(ColorScheme.Green, Luminosity.Light, NumberOfResults);
            var GreenDark = RandomColor.GetColors(ColorScheme.Green, Luminosity.Dark, NumberOfResults);
            var GreenBright = RandomColor.GetColors(ColorScheme.Green, Luminosity.Bright, NumberOfResults);
            WriteObject(GreenBright);
            WriteObject(GreenDark);
            WriteObject(GreenLight);
            var MonochromeLight = RandomColor.GetColors(ColorScheme.Monochrome, Luminosity.Light, NumberOfResults);
            var MonochromeDark = RandomColor.GetColors(ColorScheme.Monochrome, Luminosity.Dark, NumberOfResults);
            var MonochromeBright = RandomColor.GetColors(ColorScheme.Monochrome, Luminosity.Bright, NumberOfResults);
            WriteObject(MonochromeBright);
            WriteObject(MonochromeDark);
            WriteObject(MonochromeLight);
            var OrangeLight = RandomColor.GetColors(ColorScheme.Orange, Luminosity.Light, NumberOfResults);
            var OrangeDark = RandomColor.GetColors(ColorScheme.Orange, Luminosity.Dark, NumberOfResults);
            var OrangeBright = RandomColor.GetColors(ColorScheme.Orange, Luminosity.Bright, NumberOfResults);
            WriteObject(OrangeBright);
            WriteObject(OrangeDark);
            WriteObject(OrangeLight);
            var PinkLight = RandomColor.GetColors(ColorScheme.Pink, Luminosity.Light, NumberOfResults);
            var PinkDark = RandomColor.GetColors(ColorScheme.Pink, Luminosity.Dark, NumberOfResults);
            var PinkBright = RandomColor.GetColors(ColorScheme.Pink, Luminosity.Bright, NumberOfResults);
            WriteObject(PinkBright);
            WriteObject(PinkDark);
            WriteObject(PinkLight);
            var PurpleLight = RandomColor.GetColors(ColorScheme.Purple, Luminosity.Light, NumberOfResults);
            var PurpleDark = RandomColor.GetColors(ColorScheme.Purple, Luminosity.Dark, NumberOfResults);
            var PurpleBright = RandomColor.GetColors(ColorScheme.Purple, Luminosity.Bright, NumberOfResults);
            WriteObject(PurpleBright);
            WriteObject(PurpleDark);
            WriteObject(PurpleLight);
            var RedLight = RandomColor.GetColors(ColorScheme.Red, Luminosity.Light, NumberOfResults);
            var RedDark = RandomColor.GetColors(ColorScheme.Red, Luminosity.Dark, NumberOfResults);
            var RedBright = RandomColor.GetColors(ColorScheme.Red, Luminosity.Bright, NumberOfResults);
            WriteObject(RedBright);
            WriteObject(RedDark);
            WriteObject(RedLight);
            var YellowLight = RandomColor.GetColors(ColorScheme.Yellow, Luminosity.Light, NumberOfResults);
            var YellowDark = RandomColor.GetColors(ColorScheme.Yellow, Luminosity.Dark, NumberOfResults);
            var YellowBright = RandomColor.GetColors(ColorScheme.Yellow, Luminosity.Bright, NumberOfResults);
            WriteObject(YellowBright);
            WriteObject(YellowDark);
            WriteObject(YellowLight);
        }
    }
}
