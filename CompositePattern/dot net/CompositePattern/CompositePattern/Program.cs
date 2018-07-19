using System;
using System.Collections.Generic;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ Only One Employee -----------");
            Employee clerk = new Employee("Tim Abcd", "Clerk");
            clerk.PrintTeamMembers();
            clerk.PrintTeamMembersAndRole();
            Console.WriteLine("-----------------------------------");


            List<IEmployee> founderTeam = new List<IEmployee>();
            List<IEmployee> ceoTeam = new List<IEmployee>();
            List<IEmployee> accountingVPTeam = new List<IEmployee>();
            List<IEmployee> managerRetailTeam = new List<IEmployee>();

            //Team Manager
            managerRetailTeam.Add(new EmployeeWithTeam("James Zz","Senior Developer",null));
            managerRetailTeam.Add(new Employee("Adam Sg", "DevOps"));
            EmployeeWithTeam managerRetail = new EmployeeWithTeam("Brad Pitt", "Manager- Retail", managerRetailTeam);

            //Team Accounting VP
            accountingVPTeam.Add(clerk);
            EmployeeWithTeam accountingVp = new EmployeeWithTeam("Don bc", "Accounting VP", accountingVPTeam);

            //Team CEO
            ceoTeam.Add(accountingVp);
            ceoTeam.Add(managerRetail);
            EmployeeWithTeam ceo = new EmployeeWithTeam("Larry Dc", "CEO", ceoTeam);

            //Team Founder
            founderTeam.Add(new EmployeeWithTeam("Sarah Cd", "Personal Secretary", null));
            founderTeam.Add(ceo);      
            EmployeeWithTeam founder = new EmployeeWithTeam("John Ab", "Founder", founderTeam);

            Console.WriteLine("----------- Employee With Team-----------");
            founder.PrintTeamMembers();
            founder.PrintTeamMembersAndRole();
            Console.WriteLine("------------------------------------------");
            Console.ReadKey();
        }
    }
}
