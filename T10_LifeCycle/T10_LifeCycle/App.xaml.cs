using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace T10_LifeCycle
{
    public partial class App : Application
    {
        private const string displayText = "Display Some Crap!";
        public string DisplayText { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Console.WriteLine("OnStart");
            Debug.WriteLine("Started!");

            if (Properties.ContainsKey(displayText))
            {
                DisplayText = (string) Properties[displayText];
            }
        }

        protected override void OnSleep()
        {
            Console.WriteLine("OnSleep");
            Debug.WriteLine("OnSleep");
            Properties[displayText] = DisplayText;
        }

        protected override void OnResume()
        {
            Console.WriteLine("OnResume");
            Debug.WriteLine("OnResume");
        }

    }
}
