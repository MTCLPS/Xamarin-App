using System;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MTC.LPS
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Signup : ContentPage
	{
		public Signup ()
		{
            InitializeComponent ();
            Name.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeSentence);
            Surname.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeSentence);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Password.IsPassword = !Password.IsPassword;
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Login();
        }

        private void Signup_Clicked(object sender, EventArgs e)
        {
            string error = "";
            try
            {
                bool password = Password.Text.Any(char.IsDigit) &&
                    Password.Text.Any(char.IsLower) &&
                    Password.Text.Any(char.IsUpper);
                if (Name.Text.Length < 2)
                    error += "Name is too short \n";
                if (Surname.Text.Length < 2)
                    error += "Surname is too short \n";
                if (Num.Text.Length != 8)
                    error += "Number is incorrect \n";
                if (!IsValidEmail(Email.Text))
                    error += "Invalid Email \n";
                if (Password.Text.Length <= 6)
                    error += "Password is too short \n";
                else if (!password)
                    error += "Password must contain at least one uppercase letter, one lowercase and one digit \n";
                if (ConPass.Text != Password.Text)
                    error += "Password doesn't match";

                if (error == "")
                {
                    Application.Current.MainPage = new MainApp.HomePage(Name.Text + " " + Surname.Text);
                }
                else DisplayAlert("Failed to create an account", error, "Back");
            }
            catch
            {
                DisplayAlert("Failed to create an account", "Please fill in all the the entry fields", "Back");
            }
        }
        public static bool IsValidEmail(string mail)
        {
            try
            {
                int length = mail.Length;
            int i = mail.IndexOf('@');
            string second_part;

                second_part = mail.Substring(i);

            if (i > 0 && second_part.IndexOf('.') > 1 && second_part.IndexOf('.') < second_part.Length)
                return true;
            }
            catch { return false; }
            return false;
        }
    }
}