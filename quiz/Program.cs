using System;

namespace quiz
{
    
    class Program
    {
      
        class PartTimeEmpoyee
        {
            public
           void  calculateSalary(int hour, int rate)
            {
                int sum;
                sum = hour * rate;
                Console.WriteLine("Salary is: "+ sum);
            }
        }
        class FullTimeEmpoyee
        {
            void calculateSalary(int salary, int bonus)
            {
                int sum;
                sum = salary + bonus;
                Console.WriteLine("Salary is: " + sum);
            }
        
    }
        class Emplopyee
        {
            PartTimeEmpoyee obj = new PartTimeEmpoyee();
            FullTimeEmpoyee obj2 = new FullTimeEmpoyee();
            public
                void typeofemployer()
            {
                Console.WriteLine("Enter Type \n 0 for parttime\n 1 for fulltime");
                int num;
                num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    int hours, rate;
                    Console.WriteLine("Enter hourly rate:");
                    rate = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter total Hours:");
                    hours = int.Parse(Console.ReadLine());
                    obj.calculateSalary(hours, rate);
                }
                if (num == 1)
                {
                    int salary, bonus;
                    Console.WriteLine("Enter Basic Salary:");
                    salary = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter bonus:");
                    bonus = int.Parse(Console.ReadLine());
                    obj.calculateSalary(salary, bonus);
                }
            }
        }

        static void Main(string[] args)
        {
            int total = 0;
            Console.WriteLine("how many employers you want to calculate:");
            total = int.Parse(Console.ReadLine());
            for (int i = 1; i <=total; i++)
            {
                Console.WriteLine("Enter Employer " + i + " Data:");
                Emplopyee emp = new Emplopyee();
                emp.typeofemployer();

            }
        }
    }
}
