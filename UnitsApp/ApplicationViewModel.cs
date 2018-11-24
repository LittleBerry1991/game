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
        //  игроки
        public ObservableCollection<Unit> Player1 { get; set; }
        public ObservableCollection<Unit> Player2 { get; set; }

        // конструктор класса view-model
        public ApplicationViewModel()
        {
            // инициализация игроков
            Player1 = new ObservableCollection<Unit>
            {
                new Unit { Type= "Archer", Count = Helpers.Randomize.RandomUnitSize(), ImagePath="/Images/Creature_Archer.gif"},
                new Unit { Type= "Peasant", Count = Helpers.Randomize.RandomUnitSize(), ImagePath="/Images/Creature_Peasant.gif"},
                new Unit { Type= "Swordman",  Count = Helpers.Randomize.RandomUnitSize() , ImagePath="/Images/Creature_Swordsman.gif"}
            };
            Player2 = new ObservableCollection<Unit>
            {
                new Unit { Type= "Archer", Count = Helpers.Randomize.RandomUnitSize(), ImagePath="/Images/Creature_Archer.gif"},
                new Unit { Type= "Peasant", Count = Helpers.Randomize.RandomUnitSize(), ImagePath="/Images/Creature_Peasant.gif"},
                new Unit { Type= "Swordman",  Count = Helpers.Randomize.RandomUnitSize() , ImagePath="/Images/Creature_Swordsman.gif"}
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
