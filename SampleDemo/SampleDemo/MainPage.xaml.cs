using SampleDemo.ViewModel;
using Xamarin.Forms;

namespace SampleDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
