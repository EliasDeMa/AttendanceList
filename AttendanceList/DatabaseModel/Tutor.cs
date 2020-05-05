namespace DatabaseModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("Tutor")]
    public partial class Tutor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tutor()
        {
            CourseTutors = new HashSet<CourseTutor>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseTutor> CourseTutors { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
