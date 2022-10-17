using System;
using System.Collections.Generic;
using System.Text;

namespace project_c
{
    class Employee
    {
        int id;
        string name;
        double age;
        string phone;
        string address;
        double salary;
        bool manage;
        Department department;
        DateTime salaryInc;
        #region Property
        public DateTime SalaryInc
        {
            set
            {
                salaryInc = value;

            }
            get
            {
                return salaryInc;
            }
        }
        public int Id
        {
            private set
            {
                id = value;

            }
            get
            {
                return id;
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
        public double Age
        {
            set
            {
                age = value;

            }
            get
            {
                return age;
            }
        }
        public string Phone
        {
            set
            {
                phone = value;

            }
            get
            {
                return phone;
            }
        }
        public double Salary
        {
            set
            {
                salary = value;

            }
            get
            {
                return salary;
            }
        }
        public bool Manage
        {
            set
            {
                manage = value;

            }
            get
            {
                return manage;
            }
        }
        public Department Depart
        {
            set
            {
                department = value;

            }
            get
            {
                return department;
            }
        }
        #endregion
        #region constructors
        public Employee(int _id,string _name,double _age,string _phone,string _address,double _salary, bool _manage, Department _department, DateTime _salaryInc)
        {
             id = _id;
             name = _name;
             age = _age;
             phone = _phone;
             address = _address;
             salary = _salary;
             manage = _manage;
             department = _department;
             salaryInc = _salaryInc;
        }
        public Employee() : this (1,"Romany",25.1,"01208641519","Sohag",5564.5,false,null,DateTime.Now)   
        { }
        public Employee(Employee E) 
        {
            id = E.id;
            name = E.name;
            age = E.age;
            phone = E.phone;
            address = E.address;
            salary = E.salary;
            manage = E.manage;
            department = E.department;
            salaryInc = E.salaryInc;
        }
        #endregion
        #region functions
        public Employee clone()
        {
            return new Employee(this);
        }
        public void Edit(Department D)
        {

            if (D.NavailableEMp() > 0)
            {
                D.Employees.Add(this);
                Depart.Employees.Remove(this);
                Depart = D;

            }

        }
        public bool EditsaLary()
        {
            if (DateTime.Now.Subtract(salaryInc).Days / 30 >= 6)
            {
                salary = salary + 500;
                salaryInc = DateTime.Now;
                return true;
            }
            else
                return false;
        }
        #endregion

    }
}
