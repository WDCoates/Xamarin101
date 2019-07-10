using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace XTools
{
    public class MyFingExtension : IMarkupExtension
    {
        public string Text { set; get; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return $"What is this{Text}";
        }
    }
}
