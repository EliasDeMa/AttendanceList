namespace DatabaseModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CourseInfos")]
    public partial class CourseInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CourseInfo()
        {
            CourseAttenders = new HashSet<CourseAttender>();
            CourseTutors = new HashSet<CourseTutor>();
            NonCourseDays = new HashSet<NonCourseDay>();
            RegistrationTimes = new HashSet<RegistrationTime>();
        }

        public int Id { get; set; }

        public string TrainingInstitution { get; set; }

        public string Course { get; set; }

        public string ContactPerson { get; set; }

        public string Address { get; set; }

        public string ReferenceAddress { get; set; }

        public int? OeNumber { get; set; }

        public int? CourseCode { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseAttender> CourseAttenders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseTutor> CourseTutors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NonCourseDay> NonCourseDays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistrationTime> RegistrationTimes { get; set; }

        public override string ToString()
        {
            return Course;
        }
    }
}
