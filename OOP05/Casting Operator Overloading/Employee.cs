using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Casting_Operator_Overloading
{
    // Model : Class That Representing Table Existed At Database
    internal class Employee
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Guid SecurityStamp { get; set; }
    }
}
