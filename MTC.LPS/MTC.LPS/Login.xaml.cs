using System;

using MTC.LPS.MainApp;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MTC.LPS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Clicked(object sender, EventArgs e)
        {
            if (Email.Text != "" && Email.Text != String.Empty)
                if (Signup.IsValidEmail(Email.Text))
                    Application.Current.MainPage = new HomePage(Email.Text.Remove(Email.Text.IndexOf("@")));
        }

        private void Signup_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Signup();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Password.IsPassword = !Password.IsPassword;
        }
    }
}