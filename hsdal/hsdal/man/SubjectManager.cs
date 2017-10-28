using hsdal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdal.man
{
    class SubjectManager
    {
        public static DataRepository<Subject> _d;
        public static int Save(Subject subject)
        {
            var a = new Subject
            {
                SubjectId = subject.SubjectId,
                SubjectName = subject.SubjectName,
                SubjectDescription = subject.SubjectDescription,
                SubjectUnit = subject.SubjectUnit,
                CurriculumId = subject.CurriculumId,
                ModifiedOn = subject.ModifiedOn,
                ModifiedBy = subject.ModifiedBy,
                Curriculum = subject.Curriculum
            };
            using (_d = new DataRepository<Subject>())
            {
                if (subject.SubjectId > 0)
                    _d.Update(a);
                else _d.Add(a);
                _d.SaveChanges();
            }
            return a.SubjectId;
        }
        public static bool Delete(Subject subject)
        {
            using (_d = new DataRepository<Subject>())
            {
                _d.Delete(subject);
                _d.SaveChanges();
            }
            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Subject>())
            {
                _d.Delete(d => d.SubjectId == iId);
                _d.SaveChanges();
            }
            return true;
        }
        public static List<Subject> GetAll()
        {
            using (_d = new DataRepository<Subject>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderBy(o => o.SubjectName).ToList();
            }              
        }
        public static List<Subject> GetAll(int iId)
        {
            using (_d = new DataRepository<Subject>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.SubjectId == iId).OrderBy(o => o.SubjectName).ToList();
            }
        }
        public static Subject Get(int iId)
        {
            using (_d = new DataRepository<Subject>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.FirstOrDefault(f => f.SubjectId == iId);
            }
        }
    }
}
