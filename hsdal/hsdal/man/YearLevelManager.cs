using hsdal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdal.man
{
    class YearLevelManager
    {
        public static DataRepository<YearLevel> _d;
        public static int Save(YearLevel yearLevel)
        {
            var a = new YearLevel
            {
                YearLevelId = yearLevel.YearLevelId,
                YearLevelName = yearLevel.YearLevelName,
                YearLevelDescription = yearLevel.YearLevelDescription,
                ModifiedBy = yearLevel.ModifiedBy,
                ModifiedOn = yearLevel.ModifiedOn
            };
            using (_d = new DataRepository<YearLevel>())
            {
                if (yearLevel.YearLevelId> 0)
                    _d.Update(a);
                else _d.Add(a);
                _d.SaveChanges();
            }
            return a.YearLevelId;
        }
        public static bool Delete(YearLevel yearLevel)
        {
            using (_d = new DataRepository<YearLevel>())
            {
                _d.Delete(yearLevel);
                _d.SaveChanges();
            }
            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<YearLevel>())
            {
                _d.Delete(d => d.YearLevelId== iId);
                _d.SaveChanges();
            }
            return true;
        }
        public static List<YearLevel> GetAll()
        {
            using (_d = new DataRepository<YearLevel>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderBy(o => o.YearLevelName).ToList();
            }            
        }
        public static List<YearLevel> GetAll(int iId)
        {
            using (_d = new DataRepository<YearLevel>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.YearLevelId == iId).OrderBy(o => o.YearLevelName).ToList();
            }
        }
        public static YearLevel Get(int iId)
        {
            using (_d = new DataRepository<YearLevel>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.FirstOrDefault(f => f.YearLevelId == iId);
            }
        }
    }
}
    