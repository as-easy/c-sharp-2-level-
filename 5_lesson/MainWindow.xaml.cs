﻿using System;
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
        ObservableCollection<Departmen> itemsDep = new ObservableCollection<Departmen>();
        public MainWindow()
        {
            InitializeComponent();
            FillList();
        }
        void FillList()
        {            
            itemsEmp.Add(new Employee() { Id = 1, Name = "Vasya", Age = 22, Salary = 3000 });
            itemsEmp.Add(new Employee() { Id = 2, Name = "Petya", Age = 25, Salary = 6000 });
            itemsEmp.Add(new Employee() { Id = 3, Name = "Kolya", Age = 23, Salary = 8000 });
            lbEmployee.ItemsSource = itemsEmp;

            itemsDep.Add(new Departmen() { Id = 1, Name = "IT" });
            itemsDep.Add(new Departmen() { Id = 2, Name = "NotIT" });
            lbDepartmen.ItemsSource = itemsDep;
        }
        //private void lbEmployee_Selected(object sender, RoutedEventArgs e)
        //{
        //    //MessageBox.Show(e.Source.ToString());
        //}
        private void lbEmployee_SelectionChanged(object sender,
        System.Windows.Controls.SelectionChangedEventArgs e)
        {
            MessageBox.Show(e.AddedItems[0].ToString());
        }
        private void lbDepartmen_SelectionChanged(object sender,
        System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
        //private void lbDelbDepartmen_SelectionChanged(
        //{
        //    
        //}
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            itemsEmp.Add(new Employee() { Id = 1, Name = "Sergey", Age = 26, Salary = 7000 });
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Age}\t{Salary}";
        }
    }

    public class Departmen 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Id}\t{Name}";
        }
    }

}

