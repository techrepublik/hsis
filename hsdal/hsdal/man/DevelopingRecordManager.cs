using hsdal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdal.man
{
    class DevelopingRecordManager
    {
        public static DataRepository<DevelopingRecord > _d;
        public static int Save(DevelopingRecord dRecord)
        {
            var a = new DevelopingRecord
            {
                DevelopingRecordId = dRecord.DevelopingRecordId,
                DevelopingRecordName = dRecord.DevelopingRecordName,
                DevelopingRecordComment = dRecord.DevelopingRecordComment,
                ModifiedOn = dRecord.ModifiedOn,
                ModifiedBy = dRecord.ModifiedBy
            };
            using (_d = new DataRepository<DevelopingRecord>())          
            {
                if (dRecord.DevelopingRecordId > 0)
                    _d.Update(a);
                else _d.Add(a);
                _d.SaveChanges();
            }
            return a.DevelopingRecordId;
        }
        public static bool Delete(DevelopingRecord dRecord)
        {
            using (_d = new DataRepository<DevelopingRecord>())
            {
                _d.Delete(dRecord);
                _d.SaveChanges();
            }
            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<DevelopingRecord>())
            {
                _d.Delete(d => d.DevelopingRecordId == iId);
                _d.SaveChanges();
            }
            return true;
        }
        public static List<DevelopingRecord> GetAll()
        {
            using (_d = new DataRepository<DevelopingRecord>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderBy(o => o.DevelopingRecordName).ToList();
            }
      
        }
        public static List<DevelopingRecord> GetAll(int iId)
        {
            using (_d = new DataRepository<DevelopingRecord>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.DevelopingRecordId == iId).ToList();

            }
        }
        public static DevelopingRecord Get(int iId)
        {
            using (_d = new DataRepository<DevelopingRecord>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.FirstOrDefault(f => f.DevelopingRecordId == iId);
            }
              
        }
    }
}
