using hsdal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdal.man
{
    class SystemPrefManager
    {
        public static DataRepository<SystemPreference> _d;
        public static int Save(SystemPreference systemPref)
        {
            var a = new SystemPreference
            {
                SystemPreferenceId = systemPref.SystemPreferenceId,
                SchoolName = systemPref.SchoolName,
                SchoolAddress = systemPref.SchoolAddress,
                SchoolPrincipal = systemPref.SchoolPrincipal,
                ModifiedOn = systemPref.ModifiedOn,
                ModifiedBy = systemPref.ModifiedBy
            };
            using (_d = new DataRepository<SystemPreference>())
            {
                if (systemPref.SystemPreferenceId > 0)
                    _d.Update(a);
                else _d.Add(a);
                _d.SaveChanges();
            }
            return a.SystemPreferenceId;
        }
        public static bool Delete(SystemPreference systemPref)
        {
            using (_d = new DataRepository<SystemPreference>())
            {
                _d.Delete(systemPref);
                _d.SaveChanges();
            }
            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<SystemPreference>())
            {
                _d.Delete(d => d.SystemPreferenceId == iId);
                _d.SaveChanges();
            }
            return true;
        }
        public static List<SystemPreference> GetAll()
        {
            using (_d = new DataRepository<SystemPreference>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderBy(o => o.SchoolName).ToList();
            }              
        }
        public static List<SystemPreference> GetAll(int iId)
        {
            using (_d = new DataRepository<SystemPreference>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.SystemPreferenceId == iId).OrderBy(o => o.SchoolName).ToList();
            }
        }
        public static SystemPreference Get(int iId)
        {
            using (_d = new DataRepository<SystemPreference>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.FirstOrDefault(f => f.SystemPreferenceId == iId);
            }
        }
    }
}