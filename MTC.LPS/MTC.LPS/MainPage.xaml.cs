using System;

using Xamarin.Forms;

namespace MTC.LPS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Refuse_Clicked(object sender, EventArgs e)
        {
            
        }

        private void Accept_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Signup();
        }
    }
}
