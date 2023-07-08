using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotationDemo.Models
{
    public class Employee
    {
        [DisplayName("ID")]
        [Required(ErrorMessage = "Id is mandatory")]
        public int EmpId { get; set; }


        [DisplayName("Name")]
        [Required(ErrorMessage = "Name is mandatory")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Name should be in between 5 and 20")]
        public string EmpName { get; set; }


        [DisplayName("Age")]
        [Required(ErrorMessage = "Age is mandatory")]
        [Range(20,60,ErrorMessage = "Age should be in the range of 20 and 60")]
        public int? EmpAge { get; set; }


        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender is mandatory")]
        [StringLength(50, MinimumLength = 5,ErrorMessage = "Gender should be in between 5 and 50")]
        public string EmpGender { get; set; }


        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is mandatory")]
        [RegularExpression("^([0-9a-zA-Z]([-\\.\\w])*@([0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$", ErrorMessage = "Invalid Email")]
        public string EmpEmail { get; set; }


        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is mandatory")]
        [RegularExpression(@"(?=.{8}$)((?=.*\d)|(?=.*\w+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage = "UpperCase, LowerCase, Symbols, Number, 8 characters")]
        [DataType(DataType.Password)]
        public string EmpPassword { get; set; }


        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Confirm Password is mandatory")]
        [Compare("EmpPassword",ErrorMessage = "Password is not match")]
        [DataType(DataType.Password)]
        public string EmpConfirmPassword { get; set; }


        [DisplayName("Organization Name")]
        [ReadOnly(true)]
        public string EmpOrganization { get; set; }


        [DisplayName("Address")]
        [Required(ErrorMessage = "Address is mandatory")]
        [DataType(DataType.MultilineText)]
        public string EmpAddress { get; set; }


        [DisplayName("Joining Date")]
        [Required(ErrorMessage = "Date is mandatory")]
        [DataType(DataType.Date)]
        public string EmpJoinDate { get; set; }


        [DisplayName("Joining Time")]
        [Required(ErrorMessage = "Time is mandatory")]
        [DataType(DataType.Time)]
        public string EmpJoinTime { get; set; }

    }
}