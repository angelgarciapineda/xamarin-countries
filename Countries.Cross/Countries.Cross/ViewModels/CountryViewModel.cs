using Countries.Cross.Models;
using Countries.Cross.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Countries.Cross.ViewModels
{
    public class CountryViewModel : ViewModelBase
    {
        private bool isLoading;

        public bool IsLoading
        {
            get { return isLoading; }
            set { isLoading = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Country> countries;

        public ObservableCollection<Country> Countries
        {
            get { return countries; }
            set { countries = value; OnPropertyChanged(); }
        }


        public async Task LoadCountries()
        {

            IsLoading = true;

            var countries = await CountryService.GetCountries();
            Countries = new ObservableCollection<Country>(countries);

            IsLoading = false;
        }

    }
}
