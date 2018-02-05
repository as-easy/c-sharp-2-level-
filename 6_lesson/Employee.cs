using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace _5_lesson
{
    public class Employee : INotifyPropertyChanged
    {
        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Age}\t{Salary}\t{Departmen}";
        }

        private int id;
        public int Id
        {
            get { return this.id; }
            set
            {
                if (this.id != value)
                {
                    this.id = value;
                    this.NotifyPropertyChanged(id);
                }
            }
        }

        private string name;
        public string Name
        {
            get { return this.name; }
            set { if (this.name != value)
                {
                    this.name = value;
                    this.NotifyPropertyChanged("Name");
                }
            }
        }
       
        private int age;
        public int Age
        {
            get { return this.age; }
            set
            {
                if (this.age != value)
                {
                    this.age = value;
                    this.NotifyPropertyChanged(age);
                }
            }
        }

        private double salary;
        public double Salary
        {
            get { return this.salary; }
            set
            {
                if (this.salary != value)
                {
                    this.salary = value;
                    this.NotifyPropertyChanged(salary);
                }
            }
        }
        private string departament;
        public string Departmen
        {
            get { return this.departament; }
            set
            {
                if (this.departament != value)
                {
                    this.departament = value;
                    this.NotifyPropertyChanged("Departmen");
                }
            }
        }
       

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(int propId)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propId.ToString()));
        }
        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        //public void NotifyPropertyChanged(int propAge)
        //{
        //    if (this.PropertyChanged != null)
        //        this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        //}
        public void NotifyPropertyChanged(double propSalary)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propSalary.ToString()));
        }
        //public void NotifyPropertyChanged(string propDepartament)
        //{
        //    if (this.PropertyChanged != null)
        //        this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        //}
    }
}
