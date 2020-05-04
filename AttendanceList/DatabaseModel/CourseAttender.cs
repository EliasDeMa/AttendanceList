namespace DatabaseModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CourseAttender
    {
        public int? AttenderId { get; set; }

        public int? CourseId { get; set; }

        public int Id { get; set; }

        public virtual Attender Attender { get; set; }

        public virtual CourseInfo CourseInfo { get; set; }
    }
}
