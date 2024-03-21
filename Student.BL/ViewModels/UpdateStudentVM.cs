using Student.DAL.Data.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.BL.ViewModels
{
    public class UpdateStudentVM
    {
        public UpdateStudentVM( string fName, string lName, int age, DeptStatus department, string email, string iQLevel)
        {
           
            this.fName = fName;
            this.lName = lName;
            Age = age;
            Department = department;
            Email = email;
            IQLevel = iQLevel;
        }
        public UpdateStudentVM()
        {

        }
        

        [Required]
        [Range(18, 35)]
        public int Age { get; set; }
        [Required]
        [StringLength(50)]
        [DisplayName("First Name")]
        public string fName { get; set; }
        [Required]
        [StringLength(50)]
        [DisplayName("Last Name")]
        public string lName { get; set; }
        [Required]
        [RegularExpression(@"^\w+@[a-zA-Z0-9\-.]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid Email Format")]

        public string Email { set; get; }
        [Required]

        //[AllowedValues("SD", "UI", "WireLess", "Cloud Computing",ErrorMessage = "You Must Choose From (SD - UI - WireLess - Cloud Computing)  ")]
        [DisplayName("Department Name")]

        public DeptStatus Department { get; set; }
        [Required]
        [DisplayName("Student IQ Level")]
        public string IQLevel { get; set; }
    }
}
