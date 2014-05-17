using System;
using System.Collections.Generic;
using System.Linq;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using MvxSpinnerEnumSample.Core.Models;
using MvxSpinnerEnumSample.Core.Plugins;

namespace MvxSpinnerEnumSample.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}

        public IEnumerable<Equipment.Type> EquipmentTypes
        {
            get { return Enum.GetValues(typeof(Equipment.Type)).Cast<Equipment.Type>(); }
        }

        private Equipment.Type _selectedType;
        public Equipment.Type SelectedType
        {
            get { return _selectedType; }
            set
            {
                _selectedType = value;
                Mvx.Resolve<IToastPlugin>().Show(string.Format("You selected {0} ({1})", _selectedType, (int)_selectedType));
                RaisePropertyChanged(() => SelectedType);
            }
        }

    }
}
