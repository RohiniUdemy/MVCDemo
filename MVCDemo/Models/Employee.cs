using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Employee
    {
        [Required]
        [Range(100,300, ErrorMessage ="Employee ID should be within 100-300")]
        [Display(Name = "Employee ID")]
        public int employeeId { get; set; }
        [Required]
        [Display(Name = "Employee Name")]
        public String employeeName { get; set; }
        [Required]
        [Range(20, 60, ErrorMessage = "Employees should be in teh agelimit of 20-60")]
        [Display(Name = "Age")]
        public int age { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        [Display(Name = "Email")]
        public String email { get; set; }
        [Required]
        [Compare("email", ErrorMessage ="Email and Confirm Email should match.")]
        [Display(Name = "Confirm Email")]
        public String confirmEmail { get; set; }
        [Required(ErrorMessage ="You must enter a password"), Display(Name ="Password")]
        [DataType(DataType.Password)]
        [StringLength(100,MinimumLength =6, ErrorMessage ="You must have a long enough password")]        
        public String Password { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "You must enter confirm the password"), Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage ="Password and confirm password must match")]
        public String confirmPassword { get; set; }
    }
}