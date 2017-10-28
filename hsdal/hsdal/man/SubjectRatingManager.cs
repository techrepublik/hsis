using hsdal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdal.man
{
    class SubjectRatingManager
    {
        public static DataRepository<SubjectRating> _d;
        public static int Save(SubjectRating subjectRating)
        {
            var a = new SubjectRating
            {
                SubjectRatingId = subjectRating.SubjectRatingId,
                SubjectRatingOne = subjectRating.SubjectRatingOne,
                SubjectRatingTwo = subjectRating.SubjectRatingTwo,
                SubjectRatingThree = subjectRating.SubjectRatingThree,
                SubjectRatingFour = subjectRating.SubjectRatingFour,
                SubjectRatingFinalRating = subjectRating.SubjectRatingFinalRating,
                SubjectRatingUnit = subjectRating.SubjectRatingUnit,
                SubjectRatingActionTaken = subjectRating.SubjectRatingActionTaken,
                ModifiedOn = subjectRating.ModifiedOn,
                ModifiedBy = subjectRating.ModifiedBy,
                SubjectId = subjectRating.SubjectId,
                CurriculumDetailId = subjectRating.CurriculumDetailId,
                CurriculumDetail = subjectRating.CurriculumDetail,
                Subject = subjectRating.Subject
            };
            using (_d = new DataRepository<SubjectRating>())
            {
                if (subjectRating.SubjectRatingId > 0)
                    _d.Update(a);
                else _d.Add(a);
                _d.SaveChanges();
            }
            return a.SubjectRatingId;
        }
        public static bool Delete(SubjectRating subjectRating)
        {
            using (_d = new DataRepository<SubjectRating>())
            {
                _d.Delete(subjectRating);
                _d.SaveChanges();
            }
            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<SubjectRating>())
            {
                _d.Delete(d => d.SubjectRatingId == iId);
                _d.SaveChanges();
            }
            return true;
        }
        public static List<SubjectRating> GetAll()
        {
            using (_d = new DataRepository<SubjectRating>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }
        public static List<SubjectRating> GetAll(int iId)
        {
            using (_d = new DataRepository<SubjectRating>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.SubjectRatingId == iId).ToList();
            }
        }
        public static SubjectRating Get(int iId)
        {
            using (_d = new DataRepository<SubjectRating>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.FirstOrDefault(f => f.SubjectRatingId == iId);
            }
        }
    }
}