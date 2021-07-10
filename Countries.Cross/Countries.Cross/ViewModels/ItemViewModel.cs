using System;
using System.Collections.Generic;
using System.Text;
using Countries.Cross.Models;
using System.Collections.ObjectModel;

namespace Countries.Cross.ViewModels
{
    class ItemViewModel
    {
        public IList<Lang> LangList { set; get; }

        public ItemViewModel()
        {
            try
            {
                LangList = new ObservableCollection<Lang>();
                LangList.Add(new Lang { langId = 1, lang = "es", langfull = "Español" });
                LangList.Add(new Lang { langId = 1, lang = "en", langfull = "Inglés" });
            }
            catch (Exception ex)
            {

            }
        }
    }
}
