﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheCan.ViewModel
{
    class ScreenCentralModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string property)
        {
            System.Diagnostics.Debug.WriteLine(property);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }


    }
}
