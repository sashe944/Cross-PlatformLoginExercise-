using LogInExerciseApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LogInExerciseApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
            Init();
		}
        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            lblUsername.TextColor = Constants.MainTextColor;
            lblPassword.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LogInIcon.HeightRequest = Constants.LoginIconHeight;

            EntryUsername.Completed += (s, e) => EntryPassword.Focus();
            EntryPassword.Completed += (s, e) => Btn_SignInAsync(s, e);
        }
        async Task Btn_SignInAsync(object sender, EventArgs e)
        {
            User user = new User(EntryUsername.Text, EntryPassword.Text);
            if (user.CheckUserInformation())
            {
                await DisplayAlert("Login", "Login Succesfully!", "Continue");
                var result = await App.RestService.Login(user);
                if(result.Access_token!= null) {
                   App.UserDatabase.SaveUser(user);
                }
            }
            else
            {
                await DisplayAlert("Login", "Error!", "Retry");
            }
        }
    }
}