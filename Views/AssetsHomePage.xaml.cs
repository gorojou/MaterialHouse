using Acr.UserDialogs;
using MaterialHouse.Models;
using Plugin.FilePicker;
using Plugin.FilePicker.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MaterialHouse.Views
{
    public partial class AssetsHomePage : CarouselPage
    {
        public string fileNameplug = "";
        public string fileNameIdea = "";
        public string fileNamedoor = "";
        public string fileNamewindow = "";
        public string fileNameroof = "";
        public string fileNamepaint = "";
        public AssetsHomePage()
        {
            InitializeComponent();

            logo.Source = Device.OnPlatform(
            Android: "logo.png",
            iOS: null,
            WinPhone: null);

            logo0.Source = Device.OnPlatform(
            Android: "logo.png",
            iOS: null,
            WinPhone: null);

            logo.Source = Device.OnPlatform(
            Android: "logo.png",
            iOS: null,
            WinPhone: null);
            logo1.Source = Device.OnPlatform(
            Android: "logo.png",
            iOS: null,
            WinPhone: null);
            logo2.Source = Device.OnPlatform(
            Android: "logo.png",
            iOS: null,
            WinPhone: null);
            logo3.Source = Device.OnPlatform(
            Android: "logo.png",
            iOS: null,
            WinPhone: null);
            logo4.Source = Device.OnPlatform(
            Android: "logo.png",
            iOS: null,
            WinPhone: null);
            logo5.Source = Device.OnPlatform(
            Android: "logo.png",
            iOS: null,
            WinPhone: null);

           logo6.Source = Device.OnPlatform(
           Android: "logo.png",
           iOS: null,
           WinPhone: null);


            plug.Source = Device.OnPlatform(
            Android: "Plug.png",
            iOS: null,
            WinPhone: null);
            
            idea.Source = Device.OnPlatform(
            Android: "Idea.png",
            iOS: null,
            WinPhone: null);

            door.Source = Device.OnPlatform(
            Android: "Door.png",
            iOS: null,
            WinPhone: null);

            window.Source = Device.OnPlatform(
            Android: "Window.png",
            iOS: null,
            WinPhone: null);

            roof.Source = Device.OnPlatform(
            Android: "Roofing.png",
            iOS: null,
            WinPhone: null);

           paint.Source = Device.OnPlatform(
           Android: "Paint.png",
           iOS: null,
           WinPhone: null);

            note.Source = Device.OnPlatform(
            Android: "Edit.png",
            iOS: null,
            WinPhone: null);

           namepro0.Text = "Property Name: " + App.Current.Properties["PropertyName"].ToString()+ "  Address: " + App.Current.Properties["PropertyAddress"];

            //namepro0.Text = "Property Name: Test  Address: Test ";


            //namepro.Text = "Property Name: " + App.Current.Properties["PropertyName"].ToString();
            //namepro1.Text = "Property Name: " + App.Current.Properties["PropertyName"].ToString();
            //namepro2.Text = "Property Name: " + App.Current.Properties["PropertyName"].ToString();
            //namepro3.Text = "Property Name: " + App.Current.Properties["PropertyName"].ToString();
            //namepro4.Text = "Property Name: " + App.Current.Properties["PropertyName"].ToString();
            //namepro5.Text = "Property Name: " + App.Current.Properties["PropertyName"].ToString();

            InputTransparent = false; //This!

        }
        public async void OnAttachplugClicked(object sender, EventArgs e)
        {

            try

            {
                FileData fileData = await CrossFilePicker.Current.PickFile();
                Byte[] byteArray = fileData.DataArray;

                fileNameplug = fileData.FileName; 

                attachplug.Text = "Attached!";

            }
            catch (Exception ex)
            {
                await DisplayAlert("Plug ",  ex.Message , "OK");
               
            }
      
 

            
           

        }

        public async void OnAttachideaClicked(object sender, EventArgs e)
        {
            try

            {
                FileData fileData = await CrossFilePicker.Current.PickFile();
                Byte[] byteArray = fileData.DataArray;

                fileNameIdea = fileData.FileName;

                attachidea.Text = "Attached!";

            }
            catch (Exception ex)
            {
                await DisplayAlert("Appliances ", ex.Message, "OK");

            }

        }

        public async void OnAttachdoorClicked(object sender, EventArgs e)
        {
            try

            {

                FileData fileData = await CrossFilePicker.Current.PickFile();
                Byte[] byteArray = fileData.DataArray;

                fileNamedoor = fileData.FileName;

                attachdoor.Text = "Attached!";

            }
            catch (Exception ex)
            {
                await DisplayAlert("Doors ", ex.Message, "OK");

            }
            

        }


        public async void OnAttachwindowClicked(object sender, EventArgs e)
        {
            try

            {

                FileData fileData = await CrossFilePicker.Current.PickFile();
                Byte[] byteArray = fileData.DataArray;

                fileNamewindow = fileData.FileName;

                attachwindow.Text = "Attached!";

            }
            catch (Exception ex)
            {
                await DisplayAlert("Windows ", ex.Message, "OK");

            }
            

        }

        public async void OnAttachroofClicked(object sender, EventArgs e)
        {
            try

            {

                FileData fileData = await CrossFilePicker.Current.PickFile();
                Byte[] byteArray = fileData.DataArray;

                fileNameroof = fileData.FileName;

                attachroof.Text = "Attached!";

            }
            catch (Exception ex)
            {
                await DisplayAlert("Roof ", ex.Message, "OK");

            }

            

        }

        public async void OnAttachpaintClicked(object sender, EventArgs e)
        {
            try

            {

                FileData fileData = await CrossFilePicker.Current.PickFile();
                Byte[] byteArray = fileData.DataArray;

                fileNamepaint = fileData.FileName;

                attachpaint.Text = "Attached!";

            }
            catch (Exception ex)
            {
                await DisplayAlert("Paint ", ex.Message, "OK");

            }

            

        }
        
      public void OnClickedBackMenu(object sender, EventArgs e)
        {

                this.CurrentPage = page;

        }
        public  void OnClickedNext(object sender, EventArgs e)
        {
           
            int pnum = 1;
            pnum++;

            if (pnum == 2)
                this.CurrentPage = page2;
           
        }
        public void OnPlugClicked(object sender, EventArgs e)
        {

                this.CurrentPage = page1;

        }

        public void OnIdeaClicked(object sender, EventArgs e)
        {

            this.CurrentPage = page2;

        }

        public void OnDoorClicked(object sender, EventArgs e)
        {

            this.CurrentPage = page3;

        }

        public void OnWindowsClicked(object sender, EventArgs e)
        {

            this.CurrentPage = page4;

        }

        public void OnRoofClicked(object sender, EventArgs e)
        {

            this.CurrentPage = page5;

        }

        public void OnPaintClicked(object sender, EventArgs e)
        {

            this.CurrentPage = page6;

        }

        public void OnEditClicked(object sender, EventArgs e)
        {

            this.CurrentPage = page7;

        }
        public void OnaddClicked(object sender, EventArgs e)
        {

            this.CurrentPage = page8;

        }


        public async void OnSaveHVAC(object sender, EventArgs e)
        {
            try

            {
                //var path = global::Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
                //var filename = Path.Combine(path.ToString(), "myfile.txt");

                IUserDialogs Dialogs = UserDialogs.Instance;
                Dialogs.ShowLoading("Saving...");
                await Task.Delay(2000);

                Repository repository = new Repository();
                Dialogs.HideLoading();


                HVAC hvac = new HVAC();
                hvac.PropertyAsset = new PropertyAsset();
                


               var a = int.Parse(App.Current.Properties["PropertyId"].ToString());




                hvac.IDPropertyAsset = a;


                hvac.Brand = brandplug.Text;
                hvac.Warranty = warrantyplug.Text;
                hvac.Description = descripctionplug.Text;
                hvac.Comments = commentsplug.Text;
                hvac.FFile = fileNameplug;

                hvac.IDUSERPropertyAsset = int.Parse(App.Current.Properties["UsersId"].ToString());
                repository.PostHVAC(hvac);

                await DisplayAlert("HVAC", "The HVAC:  " + brandplug.Text + "  is saved ", "OK");

                GoToPage();

            }
            catch (Exception ex)
            {
                await DisplayAlert("HVAC", ex.Message, "OK");

            }

        }
        public async void OnSaveDoors(object sender, EventArgs e)
        {
            try

            {

                IUserDialogs Dialogs = UserDialogs.Instance;
                Dialogs.ShowLoading("Saving...");
                await Task.Delay(2000);

                Repository repository = new Repository();
                Dialogs.HideLoading();


                Doors doors = new Doors();
                doors.PropertyAsset = new PropertyAsset();

                doors.IDPropertyAsset= int.Parse(App.Current.Properties["PropertyId"].ToString());
                doors.Brand = branddoor.Text;
                doors.Warranty = warrantydoor.Text;
                doors.Description = descripctiondoor.Text;
                doors.Comments = commentsdoor.Text;
                doors.FFile = fileNamedoor;
                doors.IDUSERPropertyAsset = int.Parse(App.Current.Properties["UsersId"].ToString());
                repository.PostDoors(doors);

                await DisplayAlert("Doors", "The Door:  " + branddoor.Text + "  is saved ", "OK");

                GoToPage();
            }

            catch (Exception ex)
            {
                await DisplayAlert("Doors", ex.Message, "OK");

            }


        }


        public void OnClickedNext1(object sender, EventArgs e)
        {

                this.CurrentPage = page3;

        }

        public async void OnClickedBack(object sender, EventArgs e)
        {

            var MyAppsFirstPage = new LoggedPage();
            Application.Current.MainPage = new NavigationPage(MyAppsFirstPage);
            await Application.Current.MainPage.Navigation.PopAsync(); //Remove the page currently on top.
        }

        public  void GoToPage()
        {
             this.CurrentPage = page;
            //var MyAppsFirstPage = new LoggedPage();
            //Application.Current.MainPage = new NavigationPage(MyAppsFirstPage);
            //await Application.Current.MainPage.Navigation.PopAsync(); //Remove the page currently on top.
        }

        public async void OnSaveAppliances(object sender, EventArgs e)
        {
            try

            {

                IUserDialogs Dialogs = UserDialogs.Instance;
                Dialogs.ShowLoading("Saving...");
                await Task.Delay(2000);

                Repository repository = new Repository();
                Dialogs.HideLoading();

                Appliances appliances = new Appliances();
                appliances.PropertyAsset = new PropertyAsset();


                appliances.IDPropertyAsset = int.Parse(App.Current.Properties["PropertyId"].ToString());

                appliances.Brand = brandidea.Text;
                appliances.Warranty = warrantyidea.Text;
                appliances.Description = descripctionidea.Text;
                appliances.Comments = commentsidea.Text;
                appliances.FFile = fileNameIdea;
                appliances.IDUSERPropertyAsset = int.Parse(App.Current.Properties["UsersId"].ToString());
                repository.PostAppliances(appliances);

                await DisplayAlert("Appliances", "The Appliance:  " + brandidea.Text + "  is saved ", "OK");

                GoToPage();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Appliances", ex.Message, "OK");

            }

        }

        public void OnClickedNext2(object sender, EventArgs e)
        {


                this.CurrentPage = page4;

        }

        public async void OnSaveWindows(object sender, EventArgs e)
        {
            try

            {

                IUserDialogs Dialogs = UserDialogs.Instance;
                Dialogs.ShowLoading("Saving...");
                await Task.Delay(2000);

                Repository repository = new Repository();
                Dialogs.HideLoading();


                Windows win = new Windows();
                win.PropertyAsset = new PropertyAsset();

                win.IDPropertyAsset = int.Parse(App.Current.Properties["PropertyId"].ToString());
                win.Brand = brandwindow.Text;
                win.Warranty = warrantywindow.Text;
                win.Description = descripctionwindow.Text;
                win.Comments = commentswindow.Text;
                win.FFile = fileNamewindow;
                win.IDUSERPropertyAsset = int.Parse(App.Current.Properties["UsersId"].ToString());
                repository.PostWindows(win);

                await DisplayAlert("Windows", "The Windows:  " + brandwindow.Text + "  is saved ", "OK");

                GoToPage();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Windows", ex.Message, "OK");

            }

        }



        public void OnClickedNext3(object sender, EventArgs e)
        {


                this.CurrentPage = page5;

        }


        public async void OnSaveRoof(object sender, EventArgs e)
        {
            try

            {

                IUserDialogs Dialogs = UserDialogs.Instance;
                Dialogs.ShowLoading("Saving...");
                await Task.Delay(2000);

                Repository repository = new Repository();
                Dialogs.HideLoading();


                Roof roof = new Roof();
                roof.PropertyAsset = new PropertyAsset();

                roof.IDPropertyAsset = int.Parse(App.Current.Properties["PropertyId"].ToString());
                roof.Brand = brandroof.Text;
                roof.Warranty = warrantyroof.Text;
                roof.Description = descripctionroof.Text;
                roof.Comments = commentsroof.Text;
                roof.FFile = fileNameroof;
                roof.IDUSERPropertyAsset = int.Parse(App.Current.Properties["UsersId"].ToString());
                repository.PostRoof(roof);

                GoToPage();


            }
            catch (Exception ex)
            {
                await DisplayAlert("Roof", ex.Message, "OK");

            }


        }

        public void OnClickedNext4(object sender, EventArgs e)
        {

                this.CurrentPage = page6;

        }


        public async void OnSavePaint(object sender, EventArgs e)
        {
            try

            {

                IUserDialogs Dialogs = UserDialogs.Instance;
                Dialogs.ShowLoading("Saving...");
                await Task.Delay(2000);

                Repository repository = new Repository();
                Dialogs.HideLoading();


                Paint paint = new Paint();
                paint.PropertyAsset = new PropertyAsset();

                paint.IDPropertyAsset = int.Parse(App.Current.Properties["PropertyId"].ToString());
                paint.Brand = brandpaint.Text;
                paint.Warranty = warrantypaint.Text;
                paint.Description = descripctionpaint.Text;
                paint.Comments = commentspaint.Text;
                paint.FFile = fileNamepaint;
                paint.IDUSERPropertyAsset = int.Parse(App.Current.Properties["UsersId"].ToString());
                repository.PostPaint(paint);

                await DisplayAlert("Paint", "The Paint:  " + brandpaint.Text + "  is saved ", "OK");

                GoToPage();

            }
            catch (Exception ex)
            {
                await DisplayAlert("Paint", ex.Message, "OK");

            }


        }



        public void OnClickedNext5(object sender, EventArgs e)
        {

            this.CurrentPage = page7;

        }


        public async void OnSaveNote(object sender, EventArgs e)
        {
            try

            {

                IUserDialogs Dialogs = UserDialogs.Instance;
                Dialogs.ShowLoading("Saving...");
                await Task.Delay(2000);

                Repository repository = new Repository();
                Dialogs.HideLoading();


                Note note = new Note();
                note.PropertyAsset = new PropertyAsset();
                note.IDPropertyAsset= int.Parse(App.Current.Properties["PropertyId"].ToString());
                note.Description = commentsnote.Text;
                note.IDUSERPropertyAsset = int.Parse(App.Current.Properties["UsersId"].ToString());
                repository.PostNote(note);

                await DisplayAlert("Note", "The Note was created ", "OK");

                GoToPage();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Paint", ex.Message, "OK");

            }


        }

        public async void OnClickedNext6(object sender, EventArgs e)
        {
            await DisplayAlert("AssetsHome", "The Information is ready to be used", "OK");
            GoToPage();

        }
        public async void OnAddNewAsset(object sender, EventArgs e)
        {
            try
            {

                IUserDialogs Dialogs = UserDialogs.Instance;
                Dialogs.ShowLoading("Loading...");
                await Task.Delay(1000);
                Dialogs.HideLoading();

                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PushModalAsync(new NewAssetPage());
                });
            }

            catch (Exception ex)
            {
                await DisplayAlert("New Asset", ex.Message, "OK");
            }

        }


    }
        

}
