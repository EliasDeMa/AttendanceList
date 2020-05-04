namespace DatabaseModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("RegistrationTime")]
    public partial class RegistrationTime
    {
        public int Id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateTime { get; set; }

        public int? AttenderId { get; set; }

        public int? CourseId { get; set; }

        public virtual Attender Attender { get; set; }

        public virtual CourseInfo CourseInfo { get; set; }
    }
}
