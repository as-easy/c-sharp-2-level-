using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace _5_lesson
{
    /// <summary>
    /// Interaction logic for ComboboxEx.xaml
    /// </summary>
    public partial class ComboboxEx : Window
    {
        public ComboboxEx()
        {
            InitializeComponent();
            ConnectionViewModel vm = new ConnectionViewModel();
            DataContext = vm;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((ConnectionViewModel)DataContext).PhonebookEntry = "test";
        }
    }
    public class PhoneBookEntry
    {
        public string Name { get; set; }
        public PhoneBookEntry(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    public class ConnectionViewModel : INotifyPropertyChanged
    {
        public ConnectionViewModel()
        {
            IList<PhoneBookEntry> list = new List<PhoneBookEntry>();
            list.Add(new PhoneBookEntry("test"));
            list.Add(new PhoneBookEntry("test2"));
            _phonebookEntries = new CollectionView(list);
        }
        private readonly CollectionView _phonebookEntries;
        private string _phonebookEntry;

        public CollectionView PhonebookEntries
        {
            get { return _phonebookEntries; }
        }

        public string PhonebookEntry
        {
            get { return _phonebookEntry; }
            set
            {
                if (_phonebookEntry == value) return;
                _phonebookEntry = value;
                OnPropertyChanged("PhonebookEntry");
            }
        }
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}