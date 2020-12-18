using AppGetJsonDemo.ViewModel;
using Xamarin.Forms;

namespace AppGetJsonDemo.View
{
    public partial class ListagemView : ContentPage
    {
        public ListagemViewModel ViewModel { get; set; }
        public ListagemView()
        {
            this.ViewModel = new ListagemViewModel();
            this.BindingContext = this.ViewModel;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await this.ViewModel.GetDatas();
        }
    }
}