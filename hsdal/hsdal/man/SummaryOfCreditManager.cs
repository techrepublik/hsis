using hsdal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdal.man
{
    class SummaryOfCreditManager
    {
        public static DataRepository<SummaryOfCredit> _d;
        public static int Save(SummaryOfCredit summaryOfCredit)
        {
            var a = new SummaryOfCredit
            {
                SummaryOfCreditId = summaryOfCredit.SummaryOfCreditId,
                FirstCurriculumSubject = summaryOfCredit.FirstCurriculumSubject,
                FirstCurriculumYearCompleted = summaryOfCredit.FirstCurriculumYearCompleted,
                FirstCurriculumCreditsEarned = summaryOfCredit.FourthCurriculumCreditsEarned,
                SecondCurriculumSubject = summaryOfCredit.SecondCurriculumSubject,
                SecondCurriculumYearCompleted = summaryOfCredit.SecondCurriculumYearCompleted,
                SecondCurriculumCreditsEarned = summaryOfCredit.SecondCurriculumCreditsEarned,
                ThirdCurriculumSubject = summaryOfCredit.ThirdCurriculumSubject,
                ThirdCurriculumYearCompleted = summaryOfCredit.ThirdCurriculumYearCompleted,
                ThirdCurriculumCreditsEarned = summaryOfCredit.ThirdCurriculumCreditsEarned,
                FourthCurriculumSubject = summaryOfCredit.FourthCurriculumSubject,
                FourthCurriculumYearCompleted = summaryOfCredit.FourthCurriculumYearCompleted,
                FourthCurriculumCreditsEarned = summaryOfCredit.FourthCurriculumCreditsEarned,
                ModifiedOn = summaryOfCredit.ModifiedOn,
                ModifiedBy = summaryOfCredit.ModifiedBy,
                StudentId = summaryOfCredit.StudentId,
                Student = summaryOfCredit.Student
            };
            using (_d = new DataRepository<SummaryOfCredit>())
            {
                if (summaryOfCredit.SummaryOfCreditId > 0)
                    _d.Update(a);
                else _d.Add(a);
                _d.SaveChanges();
            }
            return a.SummaryOfCreditId;
        }
        public static bool Delete(SummaryOfCredit summaryOfCredit)
        {
            using (_d = new DataRepository<SummaryOfCredit>())
            {
                _d.Delete(summaryOfCredit);
                _d.SaveChanges();
            }
            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<SummaryOfCredit>())
            {
                _d.Delete(d => d.SummaryOfCreditId == iId);
                _d.SaveChanges();
            }
            return true;
        }
        public static List<SummaryOfCredit> GetAll()
        {
            using (_d = new DataRepository<SummaryOfCredit>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }               
        }
        public static List<SummaryOfCredit> GetAll(int iId)
        {
            using (_d = new DataRepository<SummaryOfCredit>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.SummaryOfCreditId == iId).ToList();
            }
        }
        public static SummaryOfCredit Get(int iId)
        {
            using (_d = new DataRepository<SummaryOfCredit>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.FirstOrDefault(f => f.SummaryOfCreditId == iId);
            }
        }
    }
}