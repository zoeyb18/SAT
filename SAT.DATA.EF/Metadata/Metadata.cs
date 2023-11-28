using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF.Models//.Metadata
{
    public class CourseMetadata
    {

        public int CourseId { get; set; }

        [Required]
        [Display(Name  = "Course")]
        [StringLength(50, ErrorMessage = "Cannot Exceed 50 Characters")]
        public string CourseName { get; set; } = null!;

        [Required]
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string CourseDescription { get; set; } = null!;

        [Required]
        [Display(Name = "Credit Hours")]
        public byte CreditHours { get; set; }

        [StringLength(250, ErrorMessage = "Cannot Exceed 250 Characters")]
        public string? Curriculum { get; set; }

        [StringLength(500, ErrorMessage = "Cannot Exceed 500 Characters")]
        public string? Notes { get; set; }

        public bool IsActive { get; set; }
    }

    public class EnrollmentMetadata
    {
        public int EnrollmentId { get; set; }

        [Required]
        [Display(Name = "Student ID")]
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "Class ID")]
        public int ScheduledClassId { get; set; }

        [Required]
        [Display(Name = "Enrollment Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime EnrollmentDate { get; set; }
    }

    public class ScheduledClassMetadata
    {
        public int ScheduledClassId { get; set; }

        [Required]
        [Display(Name = "Course ID")]
        public int CourseId { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime EndDate { get; set; }

        [Required]
        [Display(Name = "Instructor")]
        [StringLength(40, ErrorMessage = "Cannot Exceed 40 Characters")]
        public string InstructureName { get; set; } = null!;

        [Required]
        [Display(Name = "Location")]
        [StringLength(20, ErrorMessage = "Cannot Exceed 20 Characters")]
        public string Location { get; set; } = null!;

        [Required]
        [Display(Name = "SCS ID")]
        public int Scsid { get; set; }
    }

    public class ScheduledClassStatusMetadata
    {
        public int Scsid { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(50, ErrorMessage = "Cannot Exceed 50 Characters")]
        public string Scsname { get; set; } = null!;
    }

    public class StudentMetadata
    {
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(20, ErrorMessage = "Cannot Exceed 20 Characters")]
        public string FirstName { get; set; } = null!;

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(20, ErrorMessage = "Cannot Exceed 20 Characters")]
        public string LastName { get; set; } = null!;

        [StringLength(15, ErrorMessage = "Cannot Exceed 15 Characters")]
        public string? Major { get; set; }

        [StringLength(50, ErrorMessage = "Cannot Exceed 50 Characters")]
        public string? Address { get; set; }

        [StringLength(25, ErrorMessage = "Cannot Exceed 25 Characters")]
        public string? City { get; set; }

        [StringLength(2, ErrorMessage = "Cannot Exceed 2 Characters")]
        public string? State { get; set; }

        [Display(Name = "ZIP")]
        [StringLength(10, ErrorMessage = "Cannot Exceed 10 Characters")]
        [DataType(DataType.PostalCode)]
        public string? ZipCode { get; set; }

        [Display(Name = "Phone")]
        [StringLength(13, ErrorMessage = "Cannot Exceed 13 Characters")]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }

        [StringLength(50, ErrorMessage = "Cannot Exceed 50 Characters")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;

        [Display(Name = "Photo")]
        public string? PhotoUrl { get; set; }

        [Required]
        public int Ssid { get; set; }
    }

    public class StudentStatusMetadata
    {
        public int Ssid { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(30, ErrorMessage = "Cannot Exceed 30 Characters")]
        public string Ssname { get; set; } = null!;

        [Display(Name = "Description")]
        [StringLength(250, ErrorMessage = "Cannot Exceed 250 Characters")]
        public string? Ssdescription { get; set; }
    }
}
