using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace T10_LifeCycle
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Console.WriteLine("OnStart");
            Debug.WriteLine("Started!");
        }

        protected override void OnSleep()
        {
            Console.WriteLine("OnSleep");
            Debug.WriteLine("OnSleep");
        }

        protected override void OnResume()
        {
            Console.WriteLine("OnResume");
            Debug.WriteLine("OnResume");
        }

    }
}
