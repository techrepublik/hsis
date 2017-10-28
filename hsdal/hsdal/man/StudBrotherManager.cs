using hsdal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdal.man
{
    class StudBrotherManager
    {
        public static DataRepository<StudentBrother> _d;
        public static int Save(StudentBrother studBrother)
        {
            var a = new StudentBrother
            {
                BrotherId = studBrother.BrotherId,
                StudentSelectedBroId = studBrother.StudentSelectedBroId,
                StudentId = studBrother.StudentId,
                Student = studBrother.Student,
                Student1 = studBrother.Student1
            };
            using (_d = new DataRepository<StudentBrother>())
            {
                if (studBrother.BrotherId > 0)
                    _d.Update(a);
                else _d.Add(a);
                _d.SaveChanges();
            }
            return a.BrotherId;
        }
        public static bool Delete(StudentBrother studBrother)
        {
            using (_d = new DataRepository<StudentBrother>())
            {
                _d.Delete(studBrother);
                _d.SaveChanges();
            }
            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<StudentBrother>())
            {
                _d.Delete(d => d.BrotherId == iId);
                _d.SaveChanges();
            }
            return true;
        }
        public static List<StudentBrother> GetAll()
        {
            using (_d = new DataRepository<StudentBrother>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }
        public static List<StudentBrother> GetAll(int iId)
        {
            using (_d = new DataRepository<StudentBrother>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.BrotherId == iId).ToList();
            }

        }
        public static StudentBrother Get(int iId)
        {
            using (_d = new DataRepository<StudentBrother>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.FirstOrDefault(f => f.BrotherId == iId);

            }
        }
    }
}



