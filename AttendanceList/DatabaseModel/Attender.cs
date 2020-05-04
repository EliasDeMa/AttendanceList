namespace DatabaseModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("Attender")]
    public partial class Attender
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Attender()
        {
            CourseAttenders = new HashSet<CourseAttender>();
            RegistrationTimes = new HashSet<RegistrationTime>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Birthdate { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BadgeNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseAttender> CourseAttenders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistrationTime> RegistrationTimes { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
