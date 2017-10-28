using hsdal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdal.man
{
    class UserManager
    {
        public static DataRepository<User> _d;
        public static int Save(User user)
        {
            var a = new User
            {
                UserId = user.UserId,
                UserName = user.UserName,
                UserPassword = user.UserPassword,
                UserFullName = user.UserFullName,
                UserLevel = user.UserLevel,
                UserActive = user.UserActive,
                ModifiedOn = user.ModifiedOn,
                ModifiedBy = user.ModifiedBy
            };
            using (_d = new DataRepository<User>())
            {
                if (user.UserId > 0)
                    _d.Update(a);
                else _d.Add(a);
                _d.SaveChanges();
            }
            return a.UserId;
        }
        public static bool Delete(User user)
        {
            using (_d = new DataRepository<User>())
            {
                _d.Delete(user);
                _d.SaveChanges();
            }
            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<User>())
            {
                _d.Delete(d => d.UserId == iId);
                _d.SaveChanges();
            }
            return true;
        }
        public static List<User> GetAll()
        {
            using (_d = new DataRepository<User>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderBy(o => o.UserName).ToList();
            }
        }
        public static List<User> GetAll(int iId)
        {
            using (_d = new DataRepository<User>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.UserId == iId).OrderBy(o => o.UserName).ToList();
            }
        }
        public static User Get(int iId)
        {
            using (_d = new man.DataRepository<data.User>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.FirstOrDefault(f => f.UserId == iId);
            }
        }
    }
}