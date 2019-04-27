using Countries.Cross.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Countries.Cross
{
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        CountryViewModel vm;
        public MainPage()
        {
            InitializeComponent();
            vm = new CountryViewModel();
            BindingContext = vm;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await vm.LoadCountries();
        }

    }
}
