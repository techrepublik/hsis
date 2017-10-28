using hsdal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdal.man
{
    class StudentManager
    {
        public static DataRepository<Student> _d;
        public static int Save(Student student)
        {
            var a = new Student
            {
                StudentId = student.StudentId,
                StudentPhoto = student.StudentPhoto,
                StudentIdNo = student.StudentIdNo,
                StudentLRN = student.StudentLRN,
                StudentLastName = student.StudentLastName,
                StudentFirstName = student.StudentFirstName,
                StudentMiddleName = student.StudentMiddleName,
                StudentGender = student.StudentGender,
                StudentBirthDate = student.StudentBirthDate,
                StudentBirthPlace = student.StudentBirthPlace,
                StudentBarangay = student.StudentBarangay,
                StudentTown = student.StudentTown,
                StudentProvince = student.StudentProvince,
                StudentLastSchoolAttended = student.StudentLastSchoolAttended,
                StudentLastSchoolAttendedSchoolYear = student.StudentLastSchoolAttendedSchoolYear,
                StudentFathersFullName = student.StudentFathersFullName,
                StudentFathersAddress = student.StudentFathersAddress,
                StudentFathersOccupation = student.StudentFathersOccupation,
                StudentFathersTribe = student.StudentFathersTribe,
                StudentMothersFullName = student.StudentMothersFullName,
                StudentMothersAddress = student.StudentMothersAddress,
                StudentMothersOccupation = student.StudentMothersOccupation,
                StudentMothersTribe = student.StudentMothersTribe,
                StudentNumberOfYears = student.StudentNumberOfYears,
                StudentCourseCompleted = student.StudentCourseCompleted,
                StudentSchoolYearCompleted = student.StudentSchoolYearCompleted,
                StudentGeneralAverageCompleted = student.StudentGeneralAverageCompleted,
                StudentEligibleTransferTo = student.StudentEligibleTransferTo,
                StudentRemarks = student.StudentRemarks,
                CreatedBy = student.CreatedBy,
                CreatedOn = student.CreatedOn,
                ModifiedBy = student.ModifiedBy,
                ModifiedOn = student.ModifiedOn
            };
            using (_d = new DataRepository<Student>())
            {
                if (student.StudentId > 0)
                    _d.Update(a);
                else _d.Add(a);
                _d.SaveChanges();
            }
            return a.StudentId;
        }
        public static bool Delete(Student student)
        {
            using (_d = new DataRepository<Student>())
            {
                _d.Delete(student);
                _d.SaveChanges();
            }
            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Student>())
            {
                _d.Delete(d => d.StudentId == iId);
                _d.SaveChanges();
            }
            return true;
        }
        public static List<Student> GetAll()
        {
            using (_d = new man.DataRepository<data.Student>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderBy(o => o.StudentLastName).ToList();
            }                
        }
        public static List<Student> GetAll(int iId)
        {
            using (_d = new man.DataRepository<data.Student>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.StudentId == iId).OrderBy(o => o.StudentLastName).ToList();
            }
        }
        public static Student Get(int iId)
        {
            using (_d = new man.DataRepository<data.Student>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.FirstOrDefault(f => f.StudentId == iId);
            }
        }
    }
}



