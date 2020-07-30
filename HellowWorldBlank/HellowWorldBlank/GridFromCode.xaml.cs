using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Xaml;

namespace HellowWorldBlank
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridFromCode : ContentPage
    {
        public GridFromCode()
        {
            //Grid grid = new Grid
            //{
            //    RowDefinitions =
            //{
            //    new RowDefinition { Height = new GridLength(2, GridUnitType.Star) },
            //    new RowDefinition(),
            //    new RowDefinition { Height = new GridLength(100) }
            //},
            //    ColumnDefinitions =
            //{
            //    new ColumnDefinition(),
            //    new ColumnDefinition()
            //}
            //};

            //// Row 0
            //// The BoxView and Label are in row 0 and column 0, and so only needs to be added to the
            //// Grid.Children collection to get default row and column settings.
            //grid.Children.Add(new BoxView
            //{
            //    Color = Color.Green
            //});
            //grid.Children.Add(new Label
            //{
            //    Text = "Row 0, Column 0",
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center
            //});

            //// This BoxView and Label are in row 0 and column 1, which are specified as arguments
            //// to the Add method.
            //grid.Children.Add(new BoxView
            //{
            //    Color = Color.Blue
            //}, 1, 0);
            //grid.Children.Add(new Label
            //{
            //    Text = "Row 0, Column 1",
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center
            //}, 1, 0);

            //// Row 1
            //// This BoxView and Label are in row 1 and column 0, which are specified as arguments
            //// to the Add method overload.
            //grid.Children.Add(new BoxView
            //{
            //    Color = Color.Teal
            //}, 0, 1, 1, 2);
            //grid.Children.Add(new Label
            //{
            //    Text = "Row 1, Column 0",
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center
            //}, 0, 1, 1, 2); // These arguments indicate that that the child element goes in the column starting at 0 but ending before 1.
            //                // They also indicate that the child element goes in the row starting at 1 but ending before 2.

            //grid.Children.Add(new BoxView
            //{
            //    Color = Color.Purple
            //}, 1, 2, 1, 2);
            //grid.Children.Add(new Label
            //{
            //    Text = "Row1, Column 1",
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center
            //}, 1, 2, 1, 2);

            //// Row 2
            //// Alternatively, the BoxView and Label can be positioned in cells with the Grid.SetRow
            //// and Grid.SetColumn methods.
            //BoxView boxView = new BoxView { Color = Color.Red };
            ////Grid.SetRow(boxView, 2);
            ////Grid.SetColumnSpan(boxView, 2);
            //Label label = new Label
            //{
            //    Text = "Row 2, Column 0 and 1",
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center
            //};
            //Grid.SetRow(label, 2);
            //Grid.SetColumnSpan(label, 3);

            //grid.Children.Add(boxView);
            //grid.Children.Add(label);

            //Label label2 = new Label
            //{
            //    Text = "Col 2 Rows 1-3",
            //    BackgroundColor = Color.Aqua
            //};
            //Grid.SetRow(label2, 0);
            //Grid.SetColumn(label2, 2);
            //Grid.SetRowSpan(label2, 3);
            //grid.Children.Add(label2);



            //Title = "Basic Grid demo";
            //Content = grid;








            //InitializeComponent();


            var label1 = new Label { Text = "Label 1", BackgroundColor = Color.Accent };
            var label2 = new Label { Text = "Label 2", BackgroundColor = Color.AliceBlue };
            var label3 = new Label { Text = "Label 3", BackgroundColor = Color.AntiqueWhite };
            var label4 = new Label { Text = "Label 4", BackgroundColor = Color.Aqua };
            var label5 = new Label { Text = "Label 5", BackgroundColor = Color.SaddleBrown };
            var label6 = new Label { Text = "Label 6", BackgroundColor = Color.Silver };

            Grid grid = new Grid
            {
                RowSpacing = 2,
                ColumnSpacing = 2,
                BackgroundColor = Color.Yellow,
            };

            //grid.Children.Add(label1, 0, 0);
            //grid.Children.Add(label2, 1, 0);
            //grid.Children.Add(label3, 0, 1);
            //grid.Children.Add(label4, 1, 1);
            //grid.Children.Add(label5, 0, 2);
            //grid.Children.Add(label6, 2, 0);

            grid.Children.Add(label1);
            grid.Children.Add(label2);
            grid.Children.Add(label3);
            grid.Children.Add(label4);
            grid.Children.Add(label5);
            grid.Children.Add(label6);

            Grid.SetRow(label1, 0);
            Grid.SetRow(label2, 0);
            Grid.SetRow(label3, 1);
            Grid.SetRow(label4, 1);
            Grid.SetRow(label5, 2);
            Grid.SetRow(label6, 0);

            Grid.SetColumn(label1, 0);
            Grid.SetColumn(label2, 1);
            Grid.SetColumn(label3, 0);
            Grid.SetColumn(label4, 1);
            Grid.SetColumn(label5, 0);
            Grid.SetColumn(label6, 2);

            Grid.SetColumnSpan((BindableObject)label5, 2);
            Grid.SetRowSpan((BindableObject)label6, 3);



            //normally not used since included in grid.Children.Add
            //Grid.SetRow(label1, 0);
            //Grid.SetColumn(label1, 0);

            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(100, GridUnitType.Absolute)
            });
            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(2, GridUnitType.Star)
            });
            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(1, GridUnitType.Star)
            });

            grid.ColumnDefinitions.Add(new ColumnDefinition
            { Width = new GridLength(1, GridUnitType.Auto) });

            grid.ColumnDefinitions.Add(new ColumnDefinition
            { Width = new GridLength(1, GridUnitType.Star) });

            grid.ColumnDefinitions.Add(new ColumnDefinition
            { Width = new GridLength(1, GridUnitType.Star) });



            //grid.Children.Add(label1);
            //grid.Children.Add(label2);
            //grid.Children.Add(label3);
            //grid.Children.Add(label4);
            //grid.Children.Add(label5);
            //grid.Children.Add(label6);

            Content = grid;
        }
    }
}