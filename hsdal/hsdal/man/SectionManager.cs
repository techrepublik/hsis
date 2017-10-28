using hsdal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdal.man
{
    class SectionManager
    {
        public static DataRepository<Section> _d;
        public static int Save(Section section)
        {
            var a = new Section
            {
                SectionId  = section.SectionId,
                SectionName = section.SectionName,
                SectionDescription = section.SectionDescription,
                ModifiedBy = section.ModifiedBy,
                ModifiedOn = section.ModifiedOn
            };
            using (_d = new DataRepository<Section>())
            {
                if (section.SectionId > 0)
                    _d.Update(a);
                else _d.Add(a);
                _d.SaveChanges();
            }
            return a.SectionId;
        }
        public static bool Delete(Section section)
        {
            using (_d = new DataRepository<Section>())
            {
                _d.Delete(section);
                _d.SaveChanges();
            }
            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Section>())
            {
                _d.Delete(d => d.SectionId == iId);
                _d.SaveChanges();
            }
            return true;
        }
        public static List<Section> GetAll()
        {
            using (_d = new DataRepository<Section>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderBy(o => o.SectionName).ToList();
            }
                
        }
        public static List<Section> GetAll(int iId)
        {
            using (_d = new DataRepository<Section>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.SectionId == iId).OrderByDescending(o => o.SectionName).ToList();
            }
               
        }
        public static Section Get(int iId)
        {
            using (_d = new DataRepository<Section>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.FirstOrDefault(f => f.SectionId == iId);

            }
        }
    }
}


