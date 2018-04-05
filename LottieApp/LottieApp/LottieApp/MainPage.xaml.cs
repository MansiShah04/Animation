using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LottieApp
{
    public partial class MainPage : ContentPage
    {
    
        public MainPage()
        {
            try
            {  
            InitializeComponent();
            }
            catch (Exception ex)
            {

            }
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(6000);
            await Navigation.PushModalAsync(new Page1());
        }

    }
}
