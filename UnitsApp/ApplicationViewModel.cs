using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UnitsApp
{
    //  модель представления
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Unit> Units { get; set; }

        // конструктор класса view-model
        public ApplicationViewModel()
        {
            Units = new ObservableCollection<Unit>
            {
                new Unit { Type= "Archer", Count =4, ImagePath="/Images/Creature_Archer.gif"},
                new Unit { Type= "Peasant", Count =10, ImagePath="/Images/Creature_Peasant.gif"},
                new Unit { Type= "Swordman", Count =2, ImagePath="/Images/Creature_Swordsman.gif"}
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));

        }
    }
}
