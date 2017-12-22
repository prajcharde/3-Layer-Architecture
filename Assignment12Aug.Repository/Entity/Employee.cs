using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12Aug.Repository.Entity
{
    public class Employee
    {
      
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool MaritalStatus { get; set; }
        public string State { get; set; }
        public string City { get; set; }
    }
}
