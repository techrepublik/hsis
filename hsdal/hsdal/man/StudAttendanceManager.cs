using hsdal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdal.man
{
    class StudAttendanceManager
    {
        public static DataRepository<StudentAttendance> _d;
        public static int Save(StudentAttendance studAttendance)
        {
            var a = new StudentAttendance
            {
                AttendanceId = studAttendance.AttendanceId,
                AttendanceJune = studAttendance.AttendanceJune,
                AttendanceJuly = studAttendance.AttendanceJuly,
                AttendanceAugust = studAttendance.AttendanceAugust,
                AttendanceSeptember = studAttendance.AttendanceSeptember,
                AttendanceOctober = studAttendance.AttendanceOctober,
                AttendanceNovember = studAttendance.AttendanceNovember,
                AttendanceDecember = studAttendance.AttendanceDecember,
                AttendanceJanuary = studAttendance.AttendanceJanuary,
                AttendanceFebruary = studAttendance.AttendanceFebruary,
                AttendanceMarch = studAttendance.AttendanceMarch,
                AttendanceApril = studAttendance.AttendanceApril,
                AttendanceMay = studAttendance.AttendanceMay,
                AttendanceTotal = studAttendance.AttendanceTotal,
                AttendanceParticular = studAttendance.AttendanceParticular,
                ModifiedOn = studAttendance.ModifiedOn,
                ModifiedBy = studAttendance.ModifiedBy,
                CurriculumDetailId = studAttendance.CurriculumDetailId
            };

            using (_d = new DataRepository<StudentAttendance>())
            {
                if (studAttendance.AttendanceId > 0)
                    _d.Update(a);
                else _d.Add(a);
                _d.SaveChanges();
            }
            return a.AttendanceId;
        }
        public static bool Delete(StudentAttendance studAttendance)
        {
            using (_d = new DataRepository<StudentAttendance>())
            {
                _d.Delete(studAttendance);
                _d.SaveChanges();
            }
            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<StudentAttendance>())
            {
                _d.Delete(d => d.AttendanceId == iId);
                _d.SaveChanges();
            }
            return true;
        }
        public static List<StudentAttendance> GetAll()
        {
            using (_d = new DataRepository<StudentAttendance>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
              
        }
        public static List<StudentAttendance> GetAll(int iId)
        {
            using (_d = new DataRepository<StudentAttendance>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.AttendanceId == iId).ToList();
            }
                
        }
        public static StudentAttendance Get(int iId)
        {
            using (_d = new DataRepository<StudentAttendance>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.FirstOrDefault(f => f.AttendanceId == iId);
            }               
        }
    }
}



