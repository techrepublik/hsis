using hsdal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdal.man
{
    class DevelopingValueManager
    {
        public static DataRepository<DevelopingValue> _d;
        public static int Save(DevelopingValue dValue)
        {
            var a = new DevelopingValue
            {
                DevelopingValueId = dValue.DevelopingValueId,
                DevelopingValueRatings = dValue.DevelopingValueRatings,
                ModifiedOn = dValue.ModifiedOn,
                ModifiedBy = dValue.ModifiedBy,
                DevelopingRecordId = dValue.DevelopingRecordId,
                CurriculumDetailId = dValue.CurriculumDetailId               
            };
            using (_d = new DataRepository<DevelopingValue>())
            {
                if (dValue.DevelopingValueId > 0)
                    _d.Update(a);
                else _d.Add(a);
                _d.SaveChanges();
            }
            return a.DevelopingValueId;
        }
        public static bool Delete(DevelopingValue dRecord)
        {
            using (_d = new DataRepository<DevelopingValue>())
            {
                _d.Delete(dRecord);
                _d.SaveChanges();
            }
            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<DevelopingValue>())
            {
                _d.Delete(d => d.DevelopingValueId == iId);
                _d.SaveChanges();
            }
            return true;
        }
        public static List<DevelopingValue> GetAll()
        {
            using (_d = new DataRepository<DevelopingValue>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderBy(o => o.DevelopingValueRatings).ToList();
            }
               
        }
        public static List<DevelopingValue> GetAll(int iId)
        {
            using (_d = new DataRepository<DevelopingValue>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.DevelopingValueId == iId).OrderByDescending(o => o.DevelopingRecordId).ToList();
            }
                
        }
        public static DevelopingValue Get(int iId)
        {
            using (_d = new DataRepository<DevelopingValue>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.FirstOrDefault(f => f.DevelopingValueId == iId);
            }              
        }
    }
}

