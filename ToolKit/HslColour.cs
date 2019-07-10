using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToolKit
{
    public class HslColour : IMarkupExtension
    {
        public HslColour() => A = 1;

        private double A { get; set; }
        public double H { private get; set; }
        public double S { private get; set; }
        public double L { private get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Color.FromHsla(H, S, L, A);
        }

    }
}
