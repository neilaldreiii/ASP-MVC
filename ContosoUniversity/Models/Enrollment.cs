using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    /*
     * Enum is a user-defined type consisting of a set of named constants
     * called enumerators. 
     */
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade?  Grade { get; set; } // ? Means NUllable

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }

    }
}