using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace ConcertPOSystem.ViewModel
{
    public class ConcertViewModel : INotifyPropertyChanged
    {
        private Context context = new Context();
        private string orgName;
        private string place;
        private DateTime time;
        public event PropertyChangedEventHandler PropertyChanged;

        // [NotifyPropertyChangedInvocator]
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public IEnumerable<Concert> Concerts { get; set; }
        public void GetConcerts()
        {
            Concerts = context.Concert;
        }
        public ConcertViewModel()
        {
            Concerts = new List<Concert>(context.Concert);
        }
        private RelayCommand command;
        public RelayCommand Command
        {
            get
            {
                return command ?? (command = new RelayCommand(obj =>
{

}));
            }
        }
        private void Add()
        {

        }

        public string OrgName
        {
            get
            {
                return orgName;
            }

            set
            {
                orgName = value;
                OnPropertyChanged(nameof(OrgName));
            }
        }

        public string Place
        {
            get
            {
                return place;
            }

            set
            {
                place = value;
                OnPropertyChanged(nameof(Place));
            }
        }

        public DateTime Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
                OnPropertyChanged(nameof(Time));
            }
        }
    }
}
