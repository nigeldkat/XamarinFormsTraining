using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace HellowWorldBlank
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();

            slider1.Value = 0.5;
            slider2.Value = 0.5;

            //required for iOS to align properly if not centered
            //obsolete
            //Device.OnPlatform(
            //    iOS: new Thickness(0,20,0,0),
            //    Android: new Thickness(0, 0, 0, 0),
            //    WinPhone: new Thickness(0, 0,0,0)
            //    );

            var topPadding =0 ;
            switch(Device.RuntimePlatform)
            {
                case Device.iOS:
                    topPadding = 20;
                    break;
                case Device.Android:
                    topPadding = 0;
                    break;
                case Device.UWP:
                    topPadding = 30;
                    break;
            }
            this.Padding = new Thickness(0, topPadding, 0, 0);
            //label1.Text = String.Format("Value is {0:F2}", this.slider1.Value);

            //Content = new Label
            //{
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    Text = "From Code"
            //};
        }

        
        
    }
}