using System;
using System.Collections.Generic;
using System.Text;

namespace project_c
{
    class Company
    {
        string name;
        List<Department> departments = new List<Department>();
        Employee coManager;
        #region property
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
        public List<Department> Departments
        {
            set
            {
                if (value != null)
                {
                    departments = value;
                }

            }
            get
            {
                return departments;
            }
        }
        public Employee CoManager
        {
            set
            {
                if (value != null)
                {
                    coManager = value;
                }
            }
            get
            {
                return coManager;
            }
        }
        #endregion
        #region constructors
        public Company(string _name, List<Department> _departments, Employee _coManager)
        {
            name = _name;
            if (_departments != null)
            {
                departments = _departments;
                coManager = _coManager;
            }
            else
            {
                departments.Add(new Department());
                if (_coManager != null)
                {
                    coManager = _coManager;
                }
                else
                {
                    coManager = new Employee();
                }
            }
            coManager.Manage = true;
        }
        public Company()
        {
            name = "Microsoft";
            Departments.Add(new Department());
            coManager = new Employee();
            coManager.Manage = true;
        }
        public Company(Company c)
        {
            name = c.name;
            for (int i = 0; i < c.departments.Count; i++)
            {
                departments[i] = c.departments[i].clone();
            }
            coManager = c.coManager.clone();
        }
        public Company clone()
        {
            return new Company(this);
        }
        #endregion
        #region functions
        public List<Employee> SearchDE(string Dename)
        {
            foreach (Department i in departments)
            {
                if (i.Name == Dename)
                    return i.Employees;
            }
            return null;
        }
        public List<Employee> SearchDEEM(string Emname)
        {
            List<Employee> employeesfoundedbyname = new List<Employee>();

            foreach (Department i in departments)
            {
                employeesfoundedbyname.AddRange(i.SearchEM(Emname));
            }
            return employeesfoundedbyname;
        }
        public List<Employee> SearchDEEMAG(double Emage)
        {
            List<Employee> employeesfoundedbyage = new List<Employee>();

            foreach (Department i in departments)
            {
                employeesfoundedbyage.AddRange(i.SearchEM(Emage));
            }
            return employeesfoundedbyage;
        }
        public void AddDe(Department D)
        {
            this.Departments.Add(D);
        }
        public void DeleteDe(Department D)
        {
            int cOuntofEM = D.Employees.Count;

            for (int i = 0; i < cOuntofEM; i++)
            {
                D.DeleteEm(D.Employees[0]);
            }
            Departments.Remove(D);
            D.Manager = null;
            D = null;
        }
        #endregion
    }

}


