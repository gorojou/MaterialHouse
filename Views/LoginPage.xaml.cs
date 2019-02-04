using Acr.UserDialogs;
using MaterialHouse.Models;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MaterialHouse.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            logo.Source = Device.OnPlatform(
            Android: "icon.png",
            iOS: null,
            WinPhone: null);
        }

        public async void OnSignInClicked(object sender, EventArgs e)
        {
            IUserDialogs Dialogs = UserDialogs.Instance;
            Dialogs.ShowLoading("Loading...");
            await Task.Delay(1000);
            Dialogs.HideLoading();

            Device.BeginInvokeOnMainThread(async () =>
            {
                await Navigation.PushModalAsync(new PreSigninPage());
            });
            

            
        }
        public async void OnLogInClicked(object sender, EventArgs e)
        {
            //string targetUrl = "http://50.73.94.149/wsMaterialHouse";

            //await CrossConnectivity.Current.IsReachable(new Uri(targetUrl).Authority);

            try
            {
                if (!string.IsNullOrEmpty(username.Text) && !string.IsNullOrEmpty(password.Text) && username.TextColor != Color.Red)
                    {
                        IUserDialogs Dialogs = UserDialogs.Instance;
                        Dialogs.ShowLoading("Loading...");
                        await Task.Delay(2000);

                        Dialogs.HideLoading();
                    if (CrossConnectivity.Current.IsConnected == false)
                    {
                        await DisplayAlert("Log In", "Connection issues", "Ok");
                        Dialogs.HideLoading();
                        return;
                    }

                    Repository repository = new Repository();
                    var usuario = repository.LogIn(password.Text, username.Text);


						await Navigation.PushModalAsync(new AssetsHomePage());
                    else
                    {
                        await DisplayAlert("Log In", "Verify the Information", "OK");
                    }

            }

            catch (Exception ex)
            {
                //await DisplayAlert("Log In", "User not Found", "OK");
                 await DisplayAlert("Log In", ex.Message, "OK");
            }

        } 


    }
}
