namespace DatabaseModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NonCourseDay
    {
        public int Id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        public bool? Morning { get; set; }

        public bool? Afternoon { get; set; }

        public int? CourseId { get; set; }

        public virtual CourseInfo CourseInfo { get; set; }

        public override string ToString()
        {
            return Date.GetValueOrDefault().ToShortDateString();
        }
    }
}
