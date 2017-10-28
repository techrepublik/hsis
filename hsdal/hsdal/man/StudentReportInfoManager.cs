using hsdal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdal.man
{
    class StudentReportInfoManager
    {
        public static DataRepository<StudentReportInformation> _d;
        public static int Save(StudentReportInformation studentReportInfo)
        {
            var a = new StudentReportInformation
            {
                StudentReportInformationsId = studentReportInfo.StudentReportInformationsId,
                StudentReportInformationReportsName = studentReportInfo.StudentReportInformationReportsName,
                StudentReportInformationDescription = studentReportInfo.StudentReportInformationDescription,
                StudentReportInformationCode = studentReportInfo.StudentReportInformationCode,
                ModifiedOn = studentReportInfo.ModifiedOn,
                CurriculumDetailId = studentReportInfo.CurriculumDetailId,
                CurriculumDetail = studentReportInfo.CurriculumDetail
            };
            using (_d = new DataRepository<StudentReportInformation>())
            {
                if (studentReportInfo.StudentReportInformationsId > 0)
                    _d.Update(a);
                else _d.Add(a);
                _d.SaveChanges();
            }
            return a.StudentReportInformationsId;
        }
        public static bool Delete(StudentReportInformation studentReportInfo)
        {
            using (_d = new DataRepository<StudentReportInformation>())
            {
                _d.Delete(studentReportInfo);
                _d.SaveChanges();
            }
            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<StudentReportInformation>())
            {
                _d.Delete(d => d.StudentReportInformationsId == iId);
                _d.SaveChanges();
            }
            return true;
        }
        public static List<StudentReportInformation> GetAll()
        {
            using (_d = new DataRepository<StudentReportInformation>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderBy(o => o.StudentReportInformationReportsName).ToList();
            }             
        }
        public static List<StudentReportInformation> GetAll(int iId)
        {
            using (_d = new DataRepository<StudentReportInformation>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.StudentReportInformationsId == iId).OrderBy(o => o.StudentReportInformationReportsName).ToList();
            }
        }
        public static StudentReportInformation Get(int iId)
        {
            using (_d = new DataRepository<StudentReportInformation>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.FirstOrDefault(f => f.StudentReportInformationsId == iId);
            }
        }

    }
}



