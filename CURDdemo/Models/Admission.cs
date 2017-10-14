using System;

namespace CURDdemo.Models
{
    public class Admission
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public decimal? AdmissionFee { get; set; }
    }
}