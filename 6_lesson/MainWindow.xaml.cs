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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;


namespace _5_lesson
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Employee> itemsEmp = new ObservableCollection<Employee>();
        ObservableCollection<Departmens> itemsDep = new ObservableCollection<Departmens>();
        public MainWindow()
        {
            InitializeComponent();
            FillList();   
        }
    
        void FillList()
        {
            itemsDep.Add(new Departmens() { Id = 1, Name = "IT" });  //не знаю как связать с RadioButton, пока не разобрался
            itemsDep.Add(new Departmens() { Id = 2, Name = "NotIT" });

            itemsEmp.Add(new Employee() { Id = 1, Name = "Vasya", Age = 22, Salary = 3000, Departmen = itemsDep[1].Name});
            itemsEmp.Add(new Employee() { Id = 2, Name = "Petya", Age = 25, Salary = 6000, Departmen = itemsDep[0].Name });
            itemsEmp.Add(new Employee() { Id = 3, Name = "Kolya", Age = 23, Salary = 8000, Departmen = itemsDep[0].Name });
            lbEmployee.ItemsSource = itemsEmp; 
        }
        
        private void btnAddEmploy_Click(object sender, RoutedEventArgs e)
        {
            itemsEmp.Add(new Employee() { Id = 1, Name = "Sergey", Age = 26, Salary = 7000, Departmen = itemsDep[1].Name });
            stackPanel.Children.Add(new RadioButton { Content = "Tester" });
        }
        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbEmployee.SelectedItem != null)
                itemsEmp.Remove(lbEmployee.SelectedItem as Employee);
        }
        private void btnChangeUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbEmployee.SelectedItem != null)
            {
                (lbEmployee.SelectedItem as Employee).Id = 12; 
                (lbEmployee.SelectedItem as Employee).Name = "Олег";
                (lbEmployee.SelectedItem as Employee).Age = 27;
                (lbEmployee.SelectedItem as Employee).Salary = 1000.50;
                (lbEmployee.SelectedItem as Employee).Departmen = "Tester";
            }
        }
    }
}