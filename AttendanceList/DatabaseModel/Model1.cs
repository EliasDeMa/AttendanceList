namespace DatabaseModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AttendanceListContext : DbContext
    {
        public AttendanceListContext()
            : base("name=AttendanceListConnection")
        {
        }

        public virtual DbSet<Attender> Attenders { get; set; }
        public virtual DbSet<CourseAttender> CourseAttenders { get; set; }
        public virtual DbSet<CourseInfo> CourseInfoes { get; set; }
        public virtual DbSet<CourseTutor> CourseTutors { get; set; }
        public virtual DbSet<NonCourseDay> NonCourseDays { get; set; }
        public virtual DbSet<RegistrationTime> RegistrationTimes { get; set; }
        public virtual DbSet<Tutor> Tutors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseInfo>()
                .HasMany(e => e.CourseAttenders)
                .WithOptional(e => e.CourseInfo)
                .HasForeignKey(e => e.CourseId);

            modelBuilder.Entity<CourseInfo>()
                .HasMany(e => e.CourseTutors)
                .WithOptional(e => e.CourseInfo)
                .HasForeignKey(e => e.CourseId);

            modelBuilder.Entity<CourseInfo>()
                .HasMany(e => e.NonCourseDays)
                .WithOptional(e => e.CourseInfo)
                .HasForeignKey(e => e.CourseId);

            modelBuilder.Entity<CourseInfo>()
                .HasMany(e => e.RegistrationTimes)
                .WithOptional(e => e.CourseInfo)
                .HasForeignKey(e => e.CourseId);
        }
    }
}
