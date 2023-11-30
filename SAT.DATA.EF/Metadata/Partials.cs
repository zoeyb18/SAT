using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace SAT.DATA.EF.Models //Metadata
{
    #region Course
    [ModelMetadataType(typeof(CourseMetadata))]
    public partial class Course { }
    #endregion Course

    #region Enrollment
    [ModelMetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment { }
    #endregion Enrollment

    #region Scheduled Class
    [ModelMetadataType(typeof(ScheduledClassMetadata))]
    public partial class ScheduledClass { }
    #endregion Scheduled Class

    #region Scheduled Class Status
    [ModelMetadataType(typeof(ScheduledClassStatusMetadata))]
    public partial class ScheduledClassStatus { }
    #endregion Scheduled Class Status

    #region Student
    [ModelMetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
        [NotMapped]
        public IFormFile? Photo { get; set; }

        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
    #endregion Student

    #region Student Status
    [ModelMetadataType(typeof(StudentStatusMetadata))]
    public partial class StudentStatus { }
    #endregion Student Status





}
