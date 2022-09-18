using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MvvmDemo.Models;
using System.Collections.ObjectModel;

namespace MvvmDemo.ViewModels
{
    public class EmployeeViewModal : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public EmployeeService ObjEmployeeList;

        public EmployeeViewModal()
        {
            ObjEmployeeList = new EmployeeService();
            LoadData();
            CurrentEmployee = new Employee();
            saveCommand = new RelayCommand(Save);
            searchCommand = new RelayCommand(Search);
            updateCommand = new RelayCommand(Update);
            deleteCommand=new RelayCommand(Delete);

        }

        private ObservableCollection<Employee> employeeList;

        public ObservableCollection<Employee> EmployeeList
        {
            get { return employeeList; }
            set { employeeList = value; OnPropertyChanged("EmployeeList"); }
        }

        public void LoadData()
        {
            EmployeeList = new ObservableCollection<Employee>((ObjEmployeeList).ListAll());
        }

        private Employee currentEmployee;

        public Employee CurrentEmployee
        {
            get { return currentEmployee; }
            set { currentEmployee = value;OnPropertyChanged("CurrentEmployee"); }
        }

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value;OnPropertyChanged("Message"); }
        }


        private RelayCommand saveCommand;

        public RelayCommand SaveCommand
        {
            get { return saveCommand; }
        }

        public void Save()
        {
            try
            {
                var IsSaved = ObjEmployeeList.Add(CurrentEmployee);
                LoadData();
                if (IsSaved)
                {
                    Message = "Employee Saved!";
                }
                else
                {
                    Message = "Failed to save Employee";
                }
            }
            catch(Exception e)
            {
                Message=e.Message;
            }
        }


        private RelayCommand searchCommand;

        public RelayCommand SearchCommand
        {
            get { return searchCommand; }
        }

        public void Search()
        {
            try
            {
                var IsFound = ObjEmployeeList.Search(CurrentEmployee.Id);
                if (IsFound != null)
                {
                    CurrentEmployee.Name=IsFound.Name;
                    CurrentEmployee.Age = IsFound.Age;
                    Message = "Employee Found!";
                }
                else
                {
                    CurrentEmployee.Name = "";
                    CurrentEmployee.Age = 0;
                    Message = "Employee is not Present";
                }
            }
            catch (Exception e)
            {
                Message = e.Message;
            }
        }

        private RelayCommand updateCommand;

        public RelayCommand UpdateCommand
        {
            get { return updateCommand; }
        }

        public void Update()
        {
            try
            {
                var IsUpdated = ObjEmployeeList.Update(currentEmployee);
                if (IsUpdated)
                {
                    LoadData();
                    Message = "Employee is Updated";
                }
                else
                {
                    Message = "Employee Not Found";
                }
            }
            catch(Exception e)
            {
                Message=e.Message;
            }
        }

        private RelayCommand deleteCommand;

        public RelayCommand DeleteCommand
        {
            get { return deleteCommand; }
        }

        public void Delete()
        {
            try
            {
                var IsDeleted = ObjEmployeeList.Delete(currentEmployee.Id);
                if (IsDeleted)
                {
                    LoadData();
                    Message = "Employee is successfully deleted";
                }
                else
                {
                    Message = "Delete Operation Failed";
                }
            }
            catch(Exception e)
            {
                Message = e.Message;
            }
        }

    }
}
