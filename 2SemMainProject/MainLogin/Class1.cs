using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemMainProject
{
    internal class Class1
    {
        public static class Themecolor
        {
            public static Color PrimaryColor {  get; set; }
            public static Color SecondaryColor { get; set; }
            public static List <string> ColorList = new List<string>()
            {   "#DFFF00",
                "#FFBF00",
                "#FF7F50",
                "#DE3163",
                "#9FE2BF",
                "#40E0D0",
                "#6495ED",
                "#CCCCFF"


            };
            public static Color ChangeColorBrightness(Color color, double correctionFactor)
            {
                double red = color.R;
                double green = color.G;
                double blue = color.B;
                double alpha = color.A;

                //if corection factor is less than 0,darken color.
                if (correctionFactor < 0) { 
                correctionFactor = 1 + correctionFactor;
                    red = red * correctionFactor;
                    green = green * correctionFactor;
                    blue = blue * correctionFactor;
                    alpha = alpha * correctionFactor;
                }
                //if correcion factor is greater than zero,lighten color.
                else
                { 
                red = (255 -red) * correctionFactor + red;
                    green = (255 -green) * correctionFactor + green;
                        blue = (255 -blue) * correctionFactor + blue;
                }
                return Color.FromArgb(color.A,(byte)red, (byte)green, (byte)blue);
            }
        } 
    }
}
