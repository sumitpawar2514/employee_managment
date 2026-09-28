// See https://aka.ms/new-console-template for more information

namespace employee_managment
{
    interface Operation
    {
        void Display();
        double CalculateSalary();
    }

    class program
    {
        static Employee[] employees = new Employee[100];
        static int count = 0;

        static void Main()
        {
            while(true)
            {
                Console.WriteLine("----- Employee Managment System ------");
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.Search Employee");
                Console.WriteLine("3.Display All Employee");
                Console.WriteLine("4.Exit");

                Console.Write("Enter your choise :");
                int choise = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        AddEmployee();
                        break;

                    case 2:
                        SearchEmployee();
                        break;

                    case 3:
                        DisplayEmployee();
                        break;

                    case 4:
                        Console.WriteLine("Exiting progaram......");
                        break;

                    default:
                        Console.WriteLine("Invalid choise.");
                        break;
                }
            }
        }

        static void AddEmployee()
        {
            if(count>=employees.Length)
            {
                Console.WriteLine("storage is full.");
                return;
            }
            Console.WriteLine("----Select Employee Type-----");
            Console.WriteLine("1.Manager");
            Console.WriteLine("2.Developer");

            Console.Write("Enter your choise  :");
            int choise = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Id :");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee City: ");
            string city = Console.ReadLine();

            Console.Write("Enter Basic Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());


            if (choise == 1)
            {
                Console.Write("Enter Bonus: ");
                double bonus = Convert.ToDouble(Console.ReadLine());

                employees[count] = new Manager(
                    id,
                    name,
                    city,
                    salary,
                    bonus
                );

                count++;

                Console.WriteLine("Manager added successfully!");
            }
            else if (choise == 2)
            {
                Console.Write("Enter Project Allowance: ");
                double allowance = Convert.ToDouble(Console.ReadLine());

                employees[count] = new Developer(
                    id,
                    name,
                    city,
                    salary,
                    allowance
                );

                count++;

                Console.WriteLine("Developer added successfully!");
            }
            else
            {
                Console.WriteLine("Invalid employee type!");
            }
        }


        // Search Employee
        static void SearchEmployee()
        {
            Console.Write("\nEnter Employee ID to search: ");
            int id = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (employees[i].Id == id)
                {
                    employees[i].Display();
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Employee not found!");
            }
        }


        // Display All Employees
        static void DisplayEmployee()
        {
            if (count == 0)
            {
                Console.WriteLine("\nNo employees available.");
                return;
            }

            Console.WriteLine("\n------ ALL EMPLOYEES -------");

            for (int i = 0; i < count; i++)
            {
                employees[i].Display();
            }
        }
    }
}