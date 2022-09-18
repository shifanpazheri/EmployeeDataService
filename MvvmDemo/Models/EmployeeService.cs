using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmDemo.Models
{
    public class EmployeeService
    {
        public static List<Employee> ObjEmployeesList;

        public EmployeeService()
        {
            ObjEmployeesList = new List<Employee>()
            {
                new Employee(101,"David",20),new Employee(102,"Tim",20)
            };
        }

        public List<Employee> ListAll()
        {
            return ObjEmployeesList;
        }

        public bool Add(Employee objNewEmployee)
        {
            if(objNewEmployee.Age<21|| objNewEmployee.Age > 58)
            {
                throw new ArgumentException("Age is not valid");
            }
            ObjEmployeesList.Add(objNewEmployee);
            return true;
        }

        public bool Update(Employee objEmployee)
        {
            bool IsUpdated = false;
            for(int i = 0; i < ObjEmployeesList.Count; i++)
            {
                if (objEmployee.Id == ObjEmployeesList[i].Id)
                {
                    ObjEmployeesList[i] = objEmployee;
                    IsUpdated =true;
                    break;
                }
            }
            return IsUpdated;
        }

        public bool Delete(int id)
        {
            bool IsDeleted = false;
            for (int i = 0; i < ObjEmployeesList.Count; i++)
            {
                if (id == ObjEmployeesList[i].Id)
                {
                    ObjEmployeesList.RemoveAt(i);
                    IsDeleted = true;
                    break;
                }
            }
            return IsDeleted;
        }

        public Employee Search(int id)
        {
            for (int i = 0; i < ObjEmployeesList.Count; i++)
            {
                if (id == ObjEmployeesList[i].Id)
                {
                    return ObjEmployeesList[i];
                }
            }
            return null;
        }
    }
}
