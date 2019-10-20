using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRBuddy.Models
{
    public enum StillEmployed
    {
        //employment options
        FullTime,
        PartTime,
        Contracted,
        Resigned,
        Laidoff,
        Terminated
    }
    public enum Shifts
    {
        Day,
        Afternoon,
        Night,
        GraveYard
    }
    public enum Departments
    {
        Sales,
        IT,
        Marketing,
        
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Favorite Color")]
        public string FavColor { get; set; }
        public string Position { get; set; }
        public Departments Department { get; set; }
        public Shifts Shift { get; set; }
        public string Manager { get; set; }
        [Display(Name = "Employment Status")]
        public StillEmployed Employed { get; set; }
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }
    }
    //Add an img 
}

