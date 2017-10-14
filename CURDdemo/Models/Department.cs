using System.ComponentModel.DataAnnotations;

namespace CURDdemo.Models
{
    public class Department
    {
        public int DeptId { get; set; }

        [Required(ErrorMessage = "Type Department Name") ]
        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; }

        [Required(ErrorMessage = "Type Department Code")]
        [Display(Name = "Department Code")]
        public string DepartmentCode { get; set; }
    }
}