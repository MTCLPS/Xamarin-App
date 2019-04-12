using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MTC.LPS.MainApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Effects : ContentPage
	{
        Color[] Background_Colors = new Color[] { Color.Red, Color.DeepSkyBlue, Color.Gainsboro, Color.Gray, Color.Green, Color.Blue };
        public Effects()
        {
            InitializeComponent();
        }
        void Inverse_btn(object sender, EventArgs e)
        {
            int row = Grid.GetRow(Changeimg);
            int column = Grid.GetColumn(Changeimg);
            Grid.SetRow(Changeimg, Grid.GetRow(Changebtn));
            Grid.SetRow(Changebtn, Grid.GetRow(ChangeSlider));
            Grid.SetRow(ChangeSlider, Grid.GetRow(Change));
            Grid.SetRow(Change, row);
            Grid.SetColumn(Changeimg, Grid.GetColumn(Changebtn));
            Grid.SetColumn(Changebtn, Grid.GetColumn(ChangeSlider));
            Grid.SetColumn(ChangeSlider, Grid.GetColumn(Change));
            Grid.SetColumn(Change, column);

        }
        void Inverse_img(object sender, EventArgs e)
        {
            int row = Grid.GetColumn(Image1);
            var width = col1.Width;
            Grid.SetColumn(Image1, Grid.GetColumn(Image2));
            Grid.SetColumn(Image2, row);
            col1.Width = col2.Width;
            col2.Width = width;
        }

        private void Change_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            var color = Background_Colors[random.Next(Background_Colors.Length)];
            while (color == this.BackgroundColor)
                color = Background_Colors[random.Next(Background_Colors.Length)];
            this.BackgroundColor = color;
        }

        private void ChangeSlider_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            Slider1.Value = random.NextDouble();
            Slider2.Value = random.Next(360);
        }
    }
}	