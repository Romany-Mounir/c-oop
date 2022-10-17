using System;
using System.Collections.Generic;
using System.Text;

namespace project_c
{
    class Department
    {
        int noOfEmployee;
        string name;
        List<Employee>  employees = new List<Employee>();
        Employee manager;
        #region property
        public int NoOfEmployee
        {
            set
            {
                noOfEmployee = value;
            }
            get
            {
                return noOfEmployee;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public List<Employee> Employees
        {
            set
            {
                    employees = value;
            }
            get
            {
                return employees;
            }
        }
        public Employee Manager
        {
            set
            {
                if (value != null)
                {
                    manager = value;
                }
            }
            get
            {
                return manager;
            }
        }
        #endregion
        #region constructors
        public Department (int _noOfEmployee, string _name, List<Employee> _employees, Employee _manager)
        {
             noOfEmployee = _noOfEmployee;
             name = _name;
            if (_employees != null)
            {
                for (int i = 0; i < _employees.Count; i++)
                {
                    AddEm(_employees[i]);
                }
                manager = _manager;
            }
            else
            { 
                if (_manager != null)
                    {
                        manager = _manager;
                        employees.Add(manager);
                    }
                else
                    {
                        employees.Add(new Employee());
                        manager = employees[0];
                    }
            }
             manager.Manage = true;
            manager.Depart = this;
        }
        public Department () 
        {
            noOfEmployee = 500;
            name = "IT";
            employees.Add(new Employee());
            manager = employees[0];
            manager.Manage = true;
            manager.Depart = this;
        }
        public Department(Department d)
        {
            noOfEmployee = d.noOfEmployee;
            name = d.name;
            for (int i = 0; i < d.employees.Count ; i++)
            {
                employees.Add( d.employees[i].clone());
            }
            manager = d.manager.clone();
        }
        public Department clone()
        {
            return new Department(this);
        }
        #endregion
        #region functions
        public void AddEm(Employee E)
        {
            if (NavailableEMp() > 0 && E.Age > 25f)
            {
                if (E.Salary < 4000)
                {
                    E.Salary = 4000;
                    this.employees.Add(E);
                    E.Depart = this;
                    E.SalaryInc = DateTime.Now;
                }
                else
                {
                    this.employees.Add(E);
                    E.Depart = this;
                }
            }
        }
        public List<Employee> SearchEM(string Emname)
        {
            List<Employee> employeesfoundedbyname = new List<Employee>();
            foreach (Employee i in employees)
            {
                if (i.Name.ToUpper() == Emname.ToUpper())
                    employeesfoundedbyname.Add(i);
            }
            return employeesfoundedbyname;
        }
        public List<Employee> SearchEM(double Emage)
        {
            List<Employee> employeesfoundedbyage = new List<Employee>();

            foreach (Employee j in employees)
            {
                if (j.Age == Emage)
                    employeesfoundedbyage.Add(j);
            }
            return employeesfoundedbyage;
        }
        public int NavailableEMp()
        {
            return noOfEmployee - employees.Count;
        }
        public void DeleteEm(Employee E)
        {
            Employees.Remove(E);
            if (E == manager)
            {
                manager = new Employee();
                manager.Name = " WARNING!!!!!! None please contact administrator ";
            }
            E = null;
        }
#endregion
    }
}
