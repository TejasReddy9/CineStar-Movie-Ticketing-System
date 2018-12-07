using MovieEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBLL
{
    public class AdminBLL
    {

        public static bool CheckAdminBLL(Admin checkuser)
        {
            bool adminexists = false;
            try
            {
                adminexists = MovieDAL.AdminDAL.CheckUserDAL(checkuser);
            }
            catch (MovieException.MTSException e)
            {
                throw e;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return adminexists;
        }
    }
}
