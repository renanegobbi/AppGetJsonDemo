using AppGetJsonDemo.View;
using Xamarin.Forms;

namespace AppGetJsonDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ListagemView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
