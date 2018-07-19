using System;

namespace CompositePattern
{
    class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public Employee(string name, string role)
        {
            this.Name = name;
            this.Role = role;
        }
        public void PrintTeamMembers()
        {
            Console.WriteLine($"Employee Name: {this.Name}");
        }

        public void PrintTeamMembersAndRole()
        {
            Console.WriteLine($"Employee Name: {this.Name}, Employee Role: {this.Role}");
        }
    }
}
