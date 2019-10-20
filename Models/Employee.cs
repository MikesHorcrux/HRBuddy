using System;
using System.ComponentModel.DataAnnotations;

namespace HRBuddy.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string FavColor { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Shift { get; set; }
        public string Manager { get; set; }
        public int Employed { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
    }
    //Add an img 
}

