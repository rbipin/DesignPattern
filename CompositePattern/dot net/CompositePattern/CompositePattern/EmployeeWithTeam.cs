using System;
using System.Collections.Generic;

namespace CompositePattern
{
    class EmployeeWithTeam : IEmployee
    {
        public string Name { get; set; }
        public string Role { get; set; }

        int count = 0;

        public List<IEmployee> TeamMembers { get; set; }

        public EmployeeWithTeam(string name, string role, List<IEmployee> teamMembers)
        {
            this.Name = name;
            this.Role = role;
            this.TeamMembers = teamMembers;
            if (teamMembers == null)
            {
                this.count = 0;
            }
            else
            {
                this.count = teamMembers.Count;
            }
        }


        public void PrintTeamMembers()
        {
            Console.WriteLine($"Employee Name: {this.Name}");
            PrintMyTeam();
        }

        private void PrintMyTeam()
        {
            if (TeamMembers == null || TeamMembers.Count<=0)
            {
                return;
            }
            foreach (IEmployee employee in TeamMembers)
            {
                employee.PrintTeamMembers();
            }
        }

        private void PrintTeamAndRole()
        {
           if (TeamMembers == null || TeamMembers.Count<=0)
            {
                return;
            }
           foreach(IEmployee employee in TeamMembers)
            {
                employee.PrintTeamMembersAndRole();
            }
        }

        public void PrintTeamMembersAndRole()
        {
            Console.WriteLine($"Employee Name: {this.Name}, Employee Role: {this.Role}");
            PrintTeamAndRole();
        }
    }
}
