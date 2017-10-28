using hsdal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdal.man
{
    class SchoolYearManager
    {
        public static DataRepository<SchoolYear> _d;
        public static int Save(SchoolYear scYear)
        {
            var a = new SchoolYear
            {
                SchoolYearId = scYear.SchoolYearId,
                SchoolYearName = scYear.SchoolYearName,
                SchoolDescription = scYear.SchoolDescription,
                ModifiedBy = scYear.ModifiedBy,
                ModifiedOn = scYear.ModifiedOn
            };
        using (_d = new DataRepository<SchoolYear>())
            {
                if (scYear.SchoolYearId > 0)
                    _d.Update(a);
                else _d.Add(a);
                _d.SaveChanges();
            }
            return a.SchoolYearId;
        }
        public static bool Delete(SchoolYear scYear)
        {
            using (_d = new DataRepository<SchoolYear>())
            {
                _d.Delete(scYear);
                _d.SaveChanges();
            }
            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<SchoolYear>())
            {
                _d.Delete(d => d.SchoolYearId == iId);
                _d.SaveChanges();
            }
            return true;
        }
        public static List<SchoolYear> GetAll()
        {
            using (_d = new DataRepository<SchoolYear>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderBy(o => o.SchoolYearName).ToList();
            }
        }
        public static List<SchoolYear> GetAll(int iId)
        {
            using (_d = new DataRepository<SchoolYear>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.SchoolYearId == iId).OrderBy(o => o.SchoolYearName).ToList();
            }
               
        }
        public static SchoolYear Get(int iId)
       {
            using (_d = new DataRepository<SchoolYear>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.FirstOrDefault(f => f.SchoolYearId == iId);
            }                
        }
    }
}


