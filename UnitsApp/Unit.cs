using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UnitsApp
{
    //   модель юнита
    public class Unit : INotifyPropertyChanged
    {
        private string _type;
        private int _count;
        private string _imagePath;

        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("UnitType");
            }
        }

        public int Count
        {
            get { return _count; }
            set
            {
                _count = value;
                OnPropertyChanged("UnitsCount");
            }
        }

        public string ImagePath
        {
            get { return _imagePath; }
            set
            {
                _imagePath = value;
                OnPropertyChanged("UnitsImage");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
