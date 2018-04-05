using Xamarin.Forms;

namespace LottieApp
{
    // [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            this.Title = "First Page";
        }
        protected override bool OnBackButtonPressed()
        {
            //Disable device's back button click
            return true;
        }
    }
}