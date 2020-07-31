using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace HellowWorldBlank
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsoluteLayoutCode : ContentPage
    {
        public AbsoluteLayoutCode()
        {
            //InitializeComponent();


            var aquaBox = new BoxView { Color = Color.Aqua };
            var whiteBox = new BoxView { Color = Color.White };
            var button = new Button
            {
                Text = "Click Me",
                BackgroundColor = Color.Azure
            };

            var layout2 = new AbsoluteLayout()
            {
                BackgroundColor = Color.Yellow
            };

            layout2.Children.Add(aquaBox,
                new Rectangle(0,0,1,1),
                AbsoluteLayoutFlags.All);

            layout2.Children.Add(whiteBox,
                new Rectangle(.5,.1,100,100),
                AbsoluteLayoutFlags.PositionProportional);

            layout2.Children.Add(button,
                new Rectangle(0, 1, 100, 50),
                 AbsoluteLayoutFlags.PositionProportional );  //in xaml this had two values so it would go the whole width.  not sure how to combing.


            //to modify after added
            //AbsoluteLayout.SetLayoutFlags(aquaBox, AbsoluteLayoutFlags.HeightProportional);
            //AbsoluteLayout.SetLayoutBounds(aquaBox, new Rectangle(0, 0, 1, 1));
            Content = layout2;



        }
    }
}