using System;
using System.Collections.Generic;
using System.Text;

namespace project_c
{
    class Program
    {
        #region lists
        public static List<Company> companies = new List<Company>();
        public static List<Department> departments = new List<Department>();
        public static List<Department> departments2 = new List<Department>();
        public static List<Department> departments3 = new List<Department>();
        public static List<Employee> employees1 = new List<Employee>();
        public static List<Employee> employees2 = new List<Employee>();
        public static List<Employee> employees3 = new List<Employee>();
        public static List<Employee> employees4 = new List<Employee>();
        public static List<Employee> employees5 = new List<Employee>();
        public static List<Employee> employees6 = new List<Employee>();
        public static List<Employee> employees7 = new List<Employee>();
        public static List<Employee> employees8 = new List<Employee>();
        public static List<Employee> employees9 = new List<Employee>();
        public static List<Employee> employees10 = new List<Employee>();
        public static List<Employee> employees11 = new List<Employee>();
        public static List<Employee> employees12 = new List<Employee>();
        #endregion
        #region functions
        static void showpro()
        {
            Console.WriteLine("you have these companies in the list with this data ");
            for (int i = 0; i < companies.Count; i++)
            {
                Console.WriteLine((i + 1) + " - " + companies[i].Name);
                Console.WriteLine("the manager of the company is " + companies[i].CoManager.Name);
                for (int j = 0; j < companies[i].Departments.Count; j++)
                {
                    Console.WriteLine("\t" + (j + 1) + " - " + companies[i].Departments[j].Name);
                    Console.WriteLine("\t" + "the manager of the department is " + companies[i].Departments[j].Manager.Name);

                    for (int k = 0; k < companies[i].Departments[j].Employees.Count; k++)
                    {
                        Console.WriteLine("\t" + "\t" + (k + 1) + " - " + companies[i].Departments[j].Employees[k].Name);

                    }
                }
            }
        }
        static void DeleteCo(Company C)
        {
            int cOuntofDe = C.Departments.Count;
            for (int i = 0; i < cOuntofDe; i++)
            {
                C.DeleteDe(C.Departments[0]);

            }
            C.CoManager = null;
            C = null;

        }
        #endregion

        static void Main(string[] args)
        {
            #region set static companies and deparments and employees
            Employee E1 = new Employee(1, "Romany", 25.1, "01208641519", "Sohag", 5564.5, false, null, DateTime.Now);
            Employee E2 = new Employee(2, "mounir", 30, "01208641519", "Sohag", 6000, true, null, new DateTime(2020 / 5 / 1));
            Employee E3 = new Employee(3, "ahmed", 45, "01208641519", "Sohag", 4564.5, false, null, DateTime.Now);
            employees1.Add(E1);
            employees1.Add(E2);
            employees1.Add(E3);
            Employee E4 = new Employee(4, "ahmed", 45, "01208641519", "Sohag", 6000, true, null, new DateTime(2020 / 5 / 1));
            Employee E5 = new Employee(5, "mohamed", 30.5, "01208641519", "cairo", 4564.5, false, null, DateTime.Now);
            Employee E6 = new Employee(6, "dena", 25.7, "01208641519", "Sohag", 6000, false, null, new DateTime(2019 / 5 / 1));
            employees2.Add(E4);
            employees2.Add(E5);
            employees2.Add(E6);
            Employee E7 = new Employee(7, "hefny", 33, "01208641519", "cairo", 4564.5, true, null, new DateTime(2019 / 5 / 1));
            Employee E8 = new Employee(8, "gad", 30.7, "01208641519", "Alex", 4564.5, false, null, DateTime.Now);
            Employee E9 = new Employee(9, "refaat", 45.5, "01208641519", "cairo", 6000, true, null, new DateTime(2020 / 5 / 1));
            employees3.Add(E7);
            employees3.Add(E8);
            employees3.Add(E9);
            Employee E10 = new Employee(10, "magdy", 45.1, "01208641519", "Alex", 4564.5, true, null, DateTime.Now);
            Employee E11 = new Employee(11, "alaa", 45, "01208641519", "Alex", 6000, false, null, new DateTime(2019 / 5 / 1));
            Employee E12 = new Employee(12, "ali", 33.2, "01208641519", "Sohag", 8769.8, false, null, new DateTime(2020 / 5 / 1));
            employees4.Add(E10);
            employees4.Add(E11);
            employees4.Add(E12);
            Employee E111 = new Employee(111, "farghal", 45.5, "01208641519", "Alex", 8769.8, true, null, DateTime.Now);
            Employee E112 = new Employee(112, "saqly", 45.5, "01208641519", "cairo", 6000, false, null, new DateTime(2019 / 5 / 1));
            Employee E113 = new Employee(113, "ahmed", 30.7, "01208641519", "Alex", 4564.5, false, null, new DateTime(2020 / 5 / 1));
            employees5.Add(E111);
            employees5.Add(E112);
            employees5.Add(E113);
            Employee E114 = new Employee(114, "mostafa", 25, "01208641519", "Sohag", 8769.8, true, null, new DateTime(2019 / 5 / 1));
            Employee E115 = new Employee(115, "mostafa alex", 45.5, "01208641519", "Sohag", 8769.8, false, null, DateTime.Now);
            Employee E116 = new Employee(116, "shehab", 30.7, "01208641519", "cairo", 6000, false, null, new DateTime(2020 / 5 / 1));
            employees6.Add(E114);
            employees6.Add(E115);
            employees6.Add(E116);
            Employee E117 = new Employee(117, "marwa", 25, "01208641519", "Sohag", 6000, true, null, new DateTime(2019 / 5 / 1));
            Employee E118 = new Employee(118, "randa", 45.5, "01208641519", "Alex", 8769.8, false, null, DateTime.Now);
            Employee E119 = new Employee(119, "basma", 25, "01208641519", "cairo", 8769.8, false, null, new DateTime(2020 / 5 / 1));
            employees7.Add(E117);
            employees7.Add(E118);
            employees7.Add(E119);
            Employee E1110 = new Employee(1110, "sara", 33, "01208641519", "Sohag", 8769.8, true, null, new DateTime(2019 / 5 / 1));
            Employee E1111 = new Employee(1111, "basma", 45.5, "01208641519", "Alex", 8769.8, false, null, DateTime.Now);
            Employee E1112 = new Employee(1112, "hany", 30.7, "01208641519", "Alex", 6000, false, null, new DateTime(2020 / 5 / 1));
            employees8.Add(E1110);
            employees8.Add(E1111);
            employees8.Add(E1112);
            Employee E3111 = new Employee(3111, "ahmed", 33, "01208641519", "Sohag", 8769.8, true, null, DateTime.Now);
            Employee E3112 = new Employee(3112, "hany", 25, "01208641519", "Alex", 8769.8, false, null, new DateTime(2019 / 5 / 1));
            Employee E3113 = new Employee(3113, "shady", 33, "01208641519", "Alex", 8769.8, false, null, new DateTime(2020 / 5 / 1));
            employees9.Add(E3111);
            employees9.Add(E3112);
            employees9.Add(E3113);
            Employee E3114 = new Employee(3114, "mostafa", 30.7, "01208641519", "Sohag", 6000, true, null, DateTime.Now);
            Employee E3115 = new Employee(3115, "hossam", 33, "01208641519", "cairo", 8769.8, false, null, DateTime.Now);
            Employee E3116 = new Employee(3116, "sara", 38, "01208641519", "Alex", 8769.8, false, null, new DateTime(2019 / 5 / 1));
            employees10.Add(E3114);
            employees10.Add(E3115);
            employees10.Add(E3116);
            Employee E3117 = new Employee(3117, "shainaz", 33, "01208641519", "Sohag", 6000, true, null, new DateTime(2019 / 5 / 1));
            Employee E3118 = new Employee(3118, "mohamed", 38.5, "01208641519", "cairo", 8769.8, false, null, new DateTime(2020 / 5 / 1));
            Employee E3119 = new Employee(3119, "gamal", 30.7, "01208641519", "Alex", 8769.8, false, null, DateTime.Now);
            employees11.Add(E3117);
            employees11.Add(E3118);
            employees11.Add(E3119);
            Employee E31110 = new Employee(31110, "alaa", 38.7, "01208641519", "Alex", 6000, true, null, new DateTime(2019 / 5 / 1));
            Employee E31111 = new Employee(31111, "ali", 46, "01208641519", "cairo", 8769.8, false, null, DateTime.Now);
            Employee E31112 = new Employee(31112, "hossam", 33, "01208641519", "Alex", 8769.8, false, null, new DateTime(2020 / 5 / 1));
            employees12.Add(E31110);
            employees12.Add(E31111);
            employees12.Add(E31112);
            Department D1 = new Department(25, "IT", employees1, E2);
            Department D2 = new Department(5, "HR", employees2, E4);
            Department D3 = new Department(20, "PR", employees3, E7);
            Department D4 = new Department(30, "GD", employees4, E10);
            Department D11 = new Department(25, "IT", employees5, E111);
            Department D22 = new Department(15, "HR", employees6, E114);
            Department D33 = new Department(17, "PR", employees7, E117);
            Department D44 = new Department(14, "GD", employees8, E31110);
            Department D311 = new Department(25, "IT", employees9, E3111);
            Department D322 = new Department(7, "HR", employees10, E3114);
            Department D333 = new Department(33, "PR", employees11, E3117);
            Department D344 = new Department(15, "GD", employees12, E31110);
            departments.Add(D1);
            departments.Add(D2);
            departments.Add(D3);
            departments.Add(D4);
            departments2.Add(D11);
            departments2.Add(D22);
            departments2.Add(D33);
            departments2.Add(D44);
            departments3.Add(D311);
            departments3.Add(D322);
            departments3.Add(D333);
            departments3.Add(D344);
            Company C1 = new Company("micro", departments, E2);
            Company C2 = new Company("nokia", departments2, E114);
            Company C3 = new Company("dell", departments3, E31110);
            companies.Add(C1);
            companies.Add(C2);
            companies.Add(C3);
            #endregion

            Console.WriteLine("----------------------------Welcome to company project created by romany mounir labib---------------------------");
            #region take enteries from the user
            ConsoleKeyInfo keyinfo;
            do
            {
                Console.WriteLine("----------first if you want to add-------------");
                Console.WriteLine("1 - Enter \"C\" to add company");
                Console.WriteLine("2 - Enter \"D\" to add department");
                Console.WriteLine("3 - Enter \"E\" to add employee");
                Console.WriteLine("----------second if you want to remove-------------");
                Console.WriteLine("4 - Enter \"F\" to fire employee");
                Console.WriteLine("5 - Enter \"U\" to delete company");
                Console.WriteLine("6 - Enter \"I\" to delete department");
                Console.WriteLine("----------third if you want to search-------------");
                Console.WriteLine("7 - Enter \"G\" to search for employee by age in company");
                Console.WriteLine("8 - Enter \"N\" to search for employee by name in company");
                Console.WriteLine("9 - Enter \"J\" to search for employee by age in departmrnt");
                Console.WriteLine("10 - Enter \"K\" to search for employee by name in departmrnt");
                Console.WriteLine("----------forth if you want to edit-------------");
                Console.WriteLine("11 - Enter \"S\" to edit employee salary");
                Console.WriteLine("12 - Enter \"M\" to Move an employee to another department");
                Console.WriteLine("----------to exit the program Enter \"X\"-------------");
                keyinfo = Console.ReadKey();
                #endregion
                #region key cases for the developer
                switch (keyinfo.Key)
                {
                    case ConsoleKey.C:
                        Console.WriteLine("Please enter the company name");
                        string name = Console.ReadLine();
                        Console.WriteLine("------------------------- Now we need to make a manager for your company ------------------------------");
                        Console.WriteLine("Please enter the company manager id");
                        int cmid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the company manager name");
                        string cmname = Console.ReadLine();
                        Console.WriteLine("Please enter the company manager age");
                        double cmage = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the company manager phone");
                        string cmphone = Console.ReadLine();
                        Console.WriteLine("Please enter the company manager address");
                        string cmaddress = Console.ReadLine();
                        Console.WriteLine("Please enter the company manager salary");
                        double cmsalary = Convert.ToDouble(Console.ReadLine());
                        bool cmmanage = true;
                        Department cmdepartment = null;
                        DateTime cmsalaryInc = DateTime.Now;
                        Company C = new Company(name, null, new Employee(cmid, cmname, cmage, cmphone, cmaddress, cmsalary, cmmanage, cmdepartment, cmsalaryInc));
                        companies.Add(C);
                        showpro();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("----------------------------Now we go back to the main menu-----------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("you have these companies in the list ");
                        for (int i = 0; i < companies.Count; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + companies[i].Name);

                        }
                        Console.WriteLine("Please enter the company number you want to add department in the list above");
                        int cidfrmlist = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the department max numbers of employess");
                        int denoem = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the department name");
                        string dename = Console.ReadLine();
                        Console.WriteLine("------------------------- Now we need to make a manager for your department ------------------------------");
                        Console.WriteLine("Please enter the department manager id");
                        int dmid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the department manager name");
                        string dmname = Console.ReadLine();
                        Console.WriteLine("Please enter the department manager age");
                        double dmage = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the department manager phone");
                        string dmphone = Console.ReadLine();
                        Console.WriteLine("Please enter the department manager address");
                        string dmaddress = Console.ReadLine();
                        Console.WriteLine("Please enter the department manager salary");
                        double dmsalary = Convert.ToDouble(Console.ReadLine());
                        bool dmmanage = true;
                        Department dmdepartment = null;
                        DateTime dmsalaryInc = DateTime.Now;
                        Department D = new Department(denoem, dename, null, new Employee(dmid, dmname, dmage, dmphone, dmaddress, dmsalary, dmmanage, dmdepartment, dmsalaryInc));
                        companies[cidfrmlist - 1].AddDe(D);
                        showpro();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("----------------------------Now we go back to the main menu-----------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine("To add an employee you need to pick company number and department number from the list");
                        showpro();
                        Console.WriteLine("Please enter the company number here");
                        int emcidfrmlist = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the department number here");
                        int deemcidfrmlist = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the employee id");
                        int emoid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the employee name");
                        string emoname = Console.ReadLine();
                        Console.WriteLine("Please enter the employee age");
                        double emoage = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the employee phone");
                        string emophone = Console.ReadLine();
                        Console.WriteLine("Please enter the employee address");
                        string emoaddress = Console.ReadLine();
                        Console.WriteLine("Please enter the employee salary");
                        double emosalary = Convert.ToDouble(Console.ReadLine());
                        bool emomanage = false;
                        Department emodepartment = null;
                        DateTime emosalaryInc = DateTime.Now;
                        Employee E = new Employee(emoid, emoname, emoage, emophone, emoaddress, emosalary, emomanage, emodepartment, emosalaryInc);
                        companies[emcidfrmlist - 1].Departments[deemcidfrmlist - 1].AddEm(E);
                        Console.WriteLine("you have these companies in the list ");
                        for (int i = 0; i < companies.Count; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + companies[i].Name);
                            Console.WriteLine("the manager of the company is " + companies[i].CoManager.Name);
                            for (int j = 0; j < companies[i].Departments.Count; j++)
                            {
                                Console.WriteLine("\t" + (j + 1) + " - " + companies[i].Departments[j].Name);
                                Console.WriteLine("\t" + "the manager of the department is " + companies[i].Departments[j].Manager.Name);

                                for (int k = 0; k < companies[i].Departments[j].Employees.Count; k++)
                                {
                                    Console.WriteLine("\t" + "\t" + (k + 1) + " - " + companies[i].Departments[j].Employees[k].Name);

                                }
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("----------------------------Now we go back to the main menu-----------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case ConsoleKey.F:
                        Console.WriteLine("To fire an employee from company pick its number and department number and company number from the list");
                        showpro();
                        Console.WriteLine("Please enter the company number here");
                        int emcidfrmlistfire = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the department number here");
                        int deemcidfrmfire = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the employee number here");
                        int ememcidfrmfire = Convert.ToInt32(Console.ReadLine());
                        Department ddelemp = companies[emcidfrmlistfire - 1].Departments[deemcidfrmfire - 1];
                        ddelemp.DeleteEm(ddelemp.Employees[ememcidfrmfire - 1]);
                        showpro();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("----------------------------Now we go back to the main menu-----------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case ConsoleKey.G:
                        Console.WriteLine("To find employees by age from company pick company number from the list");
                        Console.WriteLine("you have these companies in the list ");
                        for (int i = 0; i < companies.Count; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + companies[i].Name);

                        }
                        Console.WriteLine("Please enter the company number here");
                        int emcidfrmlistsearchage = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the age to get the query");
                        double cmsalarysearchage = Convert.ToDouble(Console.ReadLine());
                        List<Employee> agelist = companies[emcidfrmlistsearchage - 1].SearchDEEMAG(cmsalarysearchage);
                        Console.WriteLine("here are your search result by age ");

                        Console.WriteLine("your company name is " + companies[emcidfrmlistsearchage - 1].Name);

                        for (int j = 0; j < agelist.Count; j++)
                        {
                            Console.WriteLine("\t" + (j + 1) + " - " + agelist[j].Name + " from " + agelist[j].Depart.Name);
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("----------------------------Now we go back to the main menu-----------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case ConsoleKey.I:
                        Console.WriteLine("To delete department from company pick its number and company number from the list");
                        showpro();
                        Console.WriteLine("Please enter the company number here");
                        int emcidfrmlistdeletecmde = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the department number here");
                        int deemcidfrmdeletecmde = Convert.ToInt32(Console.ReadLine());
                        companies[emcidfrmlistdeletecmde - 1].DeleteDe(companies[emcidfrmlistdeletecmde - 1].Departments[deemcidfrmdeletecmde - 1]);
                        showpro();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("----------------------------Now we go back to the main menu-----------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case ConsoleKey.J:
                        Console.WriteLine("To find employees by age from department pick company number and department number from the list");
                        showpro();
                        Console.WriteLine("Please enter the company number here");
                        int emcidfrmlistsearchagedep = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the department number here");
                        int emcfrmlistsearchagedep = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the age to get the query");
                        double cmsalarysearchagedep = Convert.ToDouble(Console.ReadLine());
                        List<Employee> agelistdep = companies[emcidfrmlistsearchagedep - 1].Departments[emcfrmlistsearchagedep - 1].SearchEM(cmsalarysearchagedep);
                        Console.WriteLine("here are your search result by age ");

                        Console.WriteLine("your company name is " + companies[emcidfrmlistsearchagedep - 1].Name);
                        Console.WriteLine("your department name is " + companies[emcidfrmlistsearchagedep - 1].Departments[emcfrmlistsearchagedep - 1].Name);

                        for (int j = 0; j < agelistdep.Count; j++)
                        {
                            Console.WriteLine("\t" + (j + 1) + " - " + agelistdep[j].Name);
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("----------------------------Now we go back to the main menu-----------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case ConsoleKey.K:
                        Console.WriteLine("To find employees by name from department pick company number and department number from the list");
                        showpro();
                        Console.WriteLine("Please enter the company number here");
                        int emcidfrmlistsearchNamedep = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the department number here");
                        int emcfrmlistsearchNamedep = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the Name to get the query");
                        string cmsalarysearchNamedep = Console.ReadLine();
                        List<Employee> Namelistdep = companies[emcidfrmlistsearchNamedep - 1].Departments[emcfrmlistsearchNamedep - 1].SearchEM(cmsalarysearchNamedep);
                        Console.WriteLine("here are your search result by age ");

                        Console.WriteLine("your company name is " + companies[emcidfrmlistsearchNamedep - 1].Name);
                        Console.WriteLine("your department name is " + companies[emcidfrmlistsearchNamedep - 1].Departments[emcfrmlistsearchNamedep - 1].Name);

                        for (int j = 0; j < Namelistdep.Count; j++)
                        {
                            Console.WriteLine("\t" + (j + 1) + " - " + Namelistdep[j].Name);
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("----------------------------Now we go back to the main menu-----------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case ConsoleKey.M:
                        Console.WriteLine("To move an employee to another department pick its number and department number and company number from the list");
                        showpro();
                        Console.WriteLine("Please enter the company number here");
                        int moveemcidfrmlistfire = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the department number here");
                        int movedeemcidfrmfire = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the employee number here");
                        int moveememcidfrmfire = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the department number you want to move the employee to it");
                        int movedeemcidfrmfireto = Convert.ToInt32(Console.ReadLine());
                        companies[moveemcidfrmlistfire - 1].Departments[movedeemcidfrmfire - 1].Employees[moveememcidfrmfire - 1].Edit(companies[moveemcidfrmlistfire - 1].Departments[movedeemcidfrmfireto - 1]);
                        showpro();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("----------------------------Now we go back to the main menu-----------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case ConsoleKey.N:
                        Console.WriteLine("To find employees by name from company pick company number from the list");
                        Console.WriteLine("you have these companies in the list ");
                        for (int i = 0; i < companies.Count; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + companies[i].Name);

                        }
                        Console.WriteLine("Please enter the company number here");
                        int emcidfrmlistsearchname = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the name to get the query");
                        string cmsalarysearchname = Console.ReadLine();
                        List<Employee> namelist = companies[emcidfrmlistsearchname - 1].SearchDEEM(cmsalarysearchname);
                        Console.WriteLine("here are your search result by name ");
                        Console.WriteLine("your company name is " + companies[emcidfrmlistsearchname - 1].Name);
                        for (int j = 0; j < namelist.Count; j++)
                        {
                            Console.WriteLine("\t" + (j + 1) + " - " + namelist[j].Name + " from " + namelist[j].Depart.Name);
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("----------------------------Now we go back to the main menu-----------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("To raise employee salary pick its number and department number and company number from the list");
                        showpro();
                        Console.WriteLine("Please enter the company number here");
                        int salemcidfrmlistfire = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the department number here");
                        int saldeemcidfrmfire = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the employee number here");
                        int salememcidfrmfire = Convert.ToInt32(Console.ReadLine());
                        if (companies[salemcidfrmlistfire - 1].Departments[saldeemcidfrmfire - 1].Employees[salememcidfrmfire - 1].EditsaLary())
                        {
                            Console.WriteLine("CONGRATULATIONS! the employee salary hass been raised by 500");

                        }
                        else
                        {
                            Console.WriteLine("SORRY the salary has been raised within the last 6 months");

                        }
                        Console.WriteLine("the employee salary is now : " + companies[salemcidfrmlistfire - 1].Departments[saldeemcidfrmfire - 1].Employees[salememcidfrmfire - 1].Salary);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("----------------------------Now we go back to the main menu-----------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case ConsoleKey.U:
                        Console.WriteLine("To delete  company pick company number from the list");
                        Console.WriteLine("you have these companies in the list ");
                        for (int i = 0; i < companies.Count; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + companies[i].Name);

                        }
                        Console.WriteLine("Please enter the company number here");
                        int cmcidfrmlistdelete = Convert.ToInt32(Console.ReadLine());

                        DeleteCo(companies[cmcidfrmlistdelete - 1]);
                        companies.RemoveAt(cmcidfrmlistdelete - 1);
                        Console.WriteLine("you have these companies in the list ");
                        for (int i = 0; i < companies.Count; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + companies[i].Name);

                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("----------------------------Now we go back to the main menu-----------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
            }
            while (keyinfo.Key != ConsoleKey.X);
            #endregion
            Console.WriteLine("----------thank you for your time-------------");
            Console.WriteLine("----------project made by Romany Mounir Labib-------------");

        }
    }
}
