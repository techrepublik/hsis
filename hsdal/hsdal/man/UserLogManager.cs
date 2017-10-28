using hsdal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdal.man
{
    class UserLogManager
    {
        public static DataRepository<UserLog> _d;
        public static int Save(UserLog userLog)
        {
            var a = new UserLog
            {
                UserLogId = userLog.UserLogId,
                UserLogIn = userLog.UserLogIn,
                UserLogOut = userLog.UserLogOut,
                UserId = userLog.UserId,
                User = userLog.User
            };
            using (_d = new DataRepository<UserLog>())
            {
                if (userLog.UserLogId> 0)
                    _d.Update(a);
                else _d.Add(a);
                _d.SaveChanges();
            }
            return a.UserLogId;
        }
        public static bool Delete(UserLog userLog)
        {
            using (_d = new DataRepository<UserLog>())
            {
                _d.Delete(userLog);
                _d.SaveChanges();
            }
            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<UserLog>())
            {
                _d.Delete(d => d.UserLogId== iId);
                _d.SaveChanges();
            }
            return true;
        }
        public static List<UserLog> GetAll()
        {
            using (_d = new DataRepository<UserLog>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }           
        }
        public static List<UserLog> GetAll(int iId)
        {
            using (_d = new DataRepository<UserLog>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.UserLogId == iId).ToList();
            }
        }
        public static UserLog Get(int iId)
        {
            using (_d = new DataRepository<UserLog>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.FirstOrDefault(f => f.UserLogId == iId);
            }
        }
    }
}