﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;

namespace PhisilyncFinal.ViewModels
{

    public partial class SUPageACVM : BaseViewModel
    {
        [RelayCommand]
        private async Task SignUp()
        {
            await Shell.Current.GoToAsync("///athleteDash");
        }
    }


}
