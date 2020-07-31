using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HellowWorldBlank
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RelativeLayoutCode : ContentPage
    {
        public RelativeLayoutCode()
        {
            InitializeComponent();

            var layout = new RelativeLayout()
            { BackgroundColor = Color.Yellow };

            var banner = new BoxView()
            {
                Color = Color.AliceBlue,
            };

            layout.Children.Add(banner,
                widthConstraint: Constraint.RelativeToParent(parent => parent.Width),
                heightConstraint: Constraint.RelativeToParent(parent => .3 * (parent.Height)));

            var pictureBox = new BoxView()
            {
                Color = Color.Silver
            };

            layout.Children.Add(pictureBox,
                yConstraint: Constraint.RelativeToView(
                    banner, (RelativeLayout, element) =>  element.Height + 20));

            Content = layout;

        }

    }
}