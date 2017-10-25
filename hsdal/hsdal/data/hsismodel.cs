namespace hsdal.data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class hsismodel : DbContext
    {
        public hsismodel()
            : base("name=hsismodel")
        {
        }

        public virtual DbSet<CurriculumDetail> CurriculumDetails { get; set; }
        public virtual DbSet<Curriculum> Curriculums { get; set; }
        public virtual DbSet<DevelopingRecord> DevelopingRecords { get; set; }
        public virtual DbSet<DevelopingValue> DevelopingValues { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<SchoolYear> SchoolYears { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<StudentAttendance> StudentAttendances { get; set; }
        public virtual DbSet<StudentBrother> StudentBrothers { get; set; }
        public virtual DbSet<StudentReportInformation> StudentReportInformations { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<SubjectRating> SubjectRatings { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<SummaryOfCredit> SummaryOfCredits { get; set; }
        public virtual DbSet<SystemPreference> SystemPreferences { get; set; }
        public virtual DbSet<UserLog> UserLogs { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<YearLevel> YearLevels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurriculumDetail>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<CurriculumDetail>()
                .HasMany(e => e.StudentReportInformations)
                .WithOptional(e => e.CurriculumDetail)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CurriculumDetail>()
                .HasMany(e => e.DevelopingValues)
                .WithOptional(e => e.CurriculumDetail)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CurriculumDetail>()
                .HasMany(e => e.StudentAttendances)
                .WithOptional(e => e.CurriculumDetail)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CurriculumDetail>()
                .HasMany(e => e.SubjectRatings)
                .WithOptional(e => e.CurriculumDetail)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Curriculum>()
                .Property(e => e.CurriculumName)
                .IsUnicode(false);

            modelBuilder.Entity<Curriculum>()
                .Property(e => e.CurriculumDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Curriculum>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<DevelopingRecord>()
                .Property(e => e.DevelopingRecordName)
                .IsUnicode(false);

            modelBuilder.Entity<DevelopingRecord>()
                .Property(e => e.DevelopingRecordComment)
                .IsUnicode(false);

            modelBuilder.Entity<DevelopingRecord>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<DevelopingValue>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<School>()
                .Property(e => e.SchoolName)
                .IsUnicode(false);

            modelBuilder.Entity<School>()
                .Property(e => e.SchoolAddress)
                .IsUnicode(false);

            modelBuilder.Entity<School>()
                .Property(e => e.SchoolDescription)
                .IsUnicode(false);

            modelBuilder.Entity<School>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<SchoolYear>()
                .Property(e => e.SchoolYearName)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolYear>()
                .Property(e => e.SchoolDescription)
                .IsUnicode(false);

            modelBuilder.Entity<SchoolYear>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<Section>()
                .Property(e => e.SectionName)
                .IsUnicode(false);

            modelBuilder.Entity<Section>()
                .Property(e => e.SectionDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Section>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<StudentAttendance>()
                .Property(e => e.AttendanceParticular)
                .IsUnicode(false);

            modelBuilder.Entity<StudentAttendance>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<StudentReportInformation>()
                .Property(e => e.StudentReportInformationReportsName)
                .IsUnicode(false);

            modelBuilder.Entity<StudentReportInformation>()
                .Property(e => e.StudentReportInformationDescription)
                .IsUnicode(false);

            modelBuilder.Entity<StudentReportInformation>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentIdNo)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentLRN)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentLastName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentMiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentGender)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentBirthPlace)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentBarangay)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentTown)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentProvince)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentLastSchoolAttended)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentLastSchoolAttendedSchoolYear)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentFathersFullName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentFathersAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentFathersOccupation)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentFathersTribe)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentMothersFullName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentMothersAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentMothersOccupation)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentMothersTribe)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentNumberOfYears)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentCourseCompleted)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentSchoolYearCompleted)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentEligibleTransferTo)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentRemarks)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.CreatedBy)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .HasMany(e => e.CurriculumDetails)
                .WithOptional(e => e.Student)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Student>()
                .HasMany(e => e.StudentBrothers)
                .WithOptional(e => e.Student)
                .HasForeignKey(e => e.StudentSelectedBroId);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.StudentBrothers1)
                .WithOptional(e => e.Student1)
                .HasForeignKey(e => e.StudentSelectedBroId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Student>()
                .HasMany(e => e.SummaryOfCredits)
                .WithOptional(e => e.Student)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SubjectRating>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<Subject>()
                .Property(e => e.SubjectName)
                .IsUnicode(false);

            modelBuilder.Entity<Subject>()
                .Property(e => e.SubjectDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Subject>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<SummaryOfCredit>()
                .Property(e => e.FirstCurriculumSubject)
                .IsUnicode(false);

            modelBuilder.Entity<SummaryOfCredit>()
                .Property(e => e.FirstCurriculumYearCompleted)
                .IsUnicode(false);

            modelBuilder.Entity<SummaryOfCredit>()
                .Property(e => e.SecondCurriculumSubject)
                .IsUnicode(false);

            modelBuilder.Entity<SummaryOfCredit>()
                .Property(e => e.SecondCurriculumYearCompleted)
                .IsUnicode(false);

            modelBuilder.Entity<SummaryOfCredit>()
                .Property(e => e.ThirdCurriculumSubject)
                .IsUnicode(false);

            modelBuilder.Entity<SummaryOfCredit>()
                .Property(e => e.ThirdCurriculumYearCompleted)
                .IsUnicode(false);

            modelBuilder.Entity<SummaryOfCredit>()
                .Property(e => e.FourthCurriculumSubject)
                .IsUnicode(false);

            modelBuilder.Entity<SummaryOfCredit>()
                .Property(e => e.FourthCurriculumYearCompleted)
                .IsUnicode(false);

            modelBuilder.Entity<SummaryOfCredit>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<SystemPreference>()
                .Property(e => e.SchoolName)
                .IsUnicode(false);

            modelBuilder.Entity<SystemPreference>()
                .Property(e => e.SchoolAddress)
                .IsUnicode(false);

            modelBuilder.Entity<SystemPreference>()
                .Property(e => e.SchoolPrincipal)
                .IsUnicode(false);

            modelBuilder.Entity<SystemPreference>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserPassword)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserFullName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserLevel)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserLogs)
                .WithOptional(e => e.User)
                .WillCascadeOnDelete();

            modelBuilder.Entity<YearLevel>()
                .Property(e => e.YearLevelName)
                .IsUnicode(false);

            modelBuilder.Entity<YearLevel>()
                .Property(e => e.YearLevelDescription)
                .IsUnicode(false);

            modelBuilder.Entity<YearLevel>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();
        }
    }
}
