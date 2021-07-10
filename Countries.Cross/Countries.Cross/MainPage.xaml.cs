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
                await vm.LoadCountries(txtCiudad.Text);
                //var clima = await CountryService.GetCountries(txtCiudad.Text);



                //if (clima != null)
                //{
                //    this.BindingContext = clima;
                //    btnBuscar.Text = "Buscar de nuevo";
                //}

            }
        }
    }
}
