using Xamarin.Forms;

namespace NavegacionDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnToSecondPage.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new SecondPage());
            };
        }
    }
}
