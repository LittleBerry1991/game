using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UnitsApp.ViewModels
{
    #region пока нахуй не нужно
    // реализация ViewModel в другом месте.  пока что
    #endregion

    //public class UnitViewModel : INotifyPropertyChanged
    //{
    //    private Unit unit;

    //    public UnitViewModel(Unit p)
    //    {
    //        unit = p;
    //    }

    //    public string UnitType
    //    {
    //        get { return unit.Type; }
    //        set
    //        {
    //            unit.Type = value;
    //            OnPropertyChanged("UnitType");
    //        }
    //    }
    //    public int UnitsCount
    //    {
    //        get { return unit.Count; }
    //        set
    //        {
    //            unit.Count = value;
    //            OnPropertyChanged("Price");
    //        }
    //    }

    //    public string ImagePath
    //    {
    //        get { return unit.ImagePath; }
    //        set
    //        {
    //            unit.ImagePath = value;
    //            OnPropertyChanged("ImagePath");
    //        }
    //    }


    //    public event PropertyChangedEventHandler PropertyChanged;
    //    public void OnPropertyChanged([CallerMemberName]string prop = "")
    //    {
    //        if (PropertyChanged != null)
    //            PropertyChanged(this, new PropertyChangedEventArgs(prop));
    //    }
    //}
}
