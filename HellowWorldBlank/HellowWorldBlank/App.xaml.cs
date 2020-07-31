using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HellowWorldBlank
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            // MainPage = new GreetPage();
            //MainPage = new StackedPage();
            //MainPage = new StackLayoutExercise();
            //MainPage = new StackedLayoutExercise2();
            //MainPage = new GridPage();
            //MainPage = new GridFromCode();
            //MainPage = new GridExample1();
            //MainPage = new GridExample2();
            //MainPage = new MyAbsoluteLayout();
            //MainPage = new AbsoluteLayoutCode();
            //MainPage = new AbsouteLayoutEx2();
            //MainPage = new RelativeLayoutXaml();
            //MainPage = new RelativeLayoutCode();
            MainPage = new RelativeLayoutEx1();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
