using Countries.Cross.Services;
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
        ItemViewModel ivm;
        public MainPage()
        {
            InitializeComponent();
            vm = new CountryViewModel();
            BindingContext = vm;
            //ivm = new ItemViewModel();
            //BindingContext = ivm;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await vm.LoadCountries("en");
        }

        private async void btnBuscar_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCiudad.Text))
            {
                switch (txtCiudad.Text.ToLower())
                {
                    case "español":
                        await vm.LoadCountries("es");
                        break;
                    case "ingles":
                        await vm.LoadCountries("en");
                        break;
                    case "frances":
                        await vm.LoadCountries("fr");
                        break;
                    case "aleman":
                        await vm.LoadCountries("de");
                        break;
                    case "portugues":
                        await vm.LoadCountries("pt");
                        break;
                    case "italiano":
                        await vm.LoadCountries("it");
                        break;
                    default:
                        await vm.LoadCountries("es");
                        break;
                }

            }
        }
    }
}
