using hsdal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdal.man
{
    class SchoolManager
    {
        public static DataRepository<School> _d;
        public static int Save(School school)
        {
            var a = new School
            {
                SchoolId = school.SchoolId,
                SchoolName = school.SchoolName,
                SchoolAddress = school.SchoolAddress,
                SchoolDescription = school.SchoolDescription,
                ModifiedOn = school.ModifiedOn,
                ModifiedBy = school.ModifiedBy
            };
            using (_d = new DataRepository<School>())
            {
                if (school.SchoolId > 0)
                    _d.Update(a);
                else _d.Add(a);
                _d.SaveChanges();
            }
            return a.SchoolId;
        }
        public static bool Delete(School school)
        {
            using (_d = new DataRepository<School>())
            {
                _d.Delete(school);
                _d.SaveChanges();
            }
            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<School>())
            {
                _d.Delete(d => d.SchoolId == iId);
                _d.SaveChanges();
            }
            return true;
        }
        public static List<School> GetAll()
        {
            using (_d = new DataRepository<School>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderBy(o => o.SchoolName).ToList();

            }
        }
        public static List<School> GetAll(int iId)
        {
            using (_d = new DataRepository<School>())
            {

                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.SchoolId == iId).ToList();
            }
        }
        public static School Get(int iId)
        {
            using (_d = new DataRepository<School>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.FirstOrDefault(f => f.SchoolId == iId);
            }              
        }
    }
}

