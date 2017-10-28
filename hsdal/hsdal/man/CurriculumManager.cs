using hsdal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdal.man
{
    class CurriculumManager
    {
        public static DataRepository<Curriculum> _d;
        public static int Save(Curriculum curriculum)
        {
            var a = new Curriculum
            {
                CurriculumId = curriculum.CurriculumId,
                CurriculumName = curriculum.CurriculumName,
                CurriculumDescription = curriculum.CurriculumDescription,
                ModifiedOn = curriculum.ModifiedOn,
                ModifiedBy = curriculum.ModifiedBy
            };
            using (_d = new DataRepository<Curriculum>())
            {
                if (curriculum.CurriculumId > 0)
                    _d.Update(a);
                else _d.Add(a);
                _d.SaveChanges();
            }
            return a.CurriculumId;
        }
        public static bool Delete(Curriculum curriculum)
        {
            using (_d = new DataRepository<Curriculum>())
            {
                _d.Delete(curriculum);
                _d.SaveChanges();
            }
            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Curriculum>())
            {
                _d.Delete(d => d.CurriculumId == iId);
                _d.SaveChanges();
            }
            return true;
        }
        public static List<Curriculum> GetAll()
        {
            using (_d = new DataRepository<Curriculum>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
           
        }
        public static List<Curriculum> GetAll(int? iId)
        {
            using (_d = new DataRepository<Curriculum>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.CurriculumId == iId).ToList();
            }
                
        }

        public static Curriculum Get(int? iId)
        {
            using (_d = new DataRepository<Curriculum>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.FirstOrDefault(f => f.CurriculumId == iId);
            }
        }
    }
}
