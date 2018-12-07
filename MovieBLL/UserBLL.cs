using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieDAL;
using MovieException;
using MovieEntity;

namespace MovieBLL
{
    public class UserBLL
    {
        private static bool ValidateUser(Users user)
        {
            StringBuilder sb = new StringBuilder();
            bool ValidUser = true;
            if (user.UserName == string.Empty)
            {
                ValidUser = false;
                sb.Append(Environment.NewLine + "Invalid Username/Password");
            }
            if (user.Password == string.Empty)
            {
                ValidUser = false;
                sb.Append(Environment.NewLine + "Invalid Username/Password");
            }
            if (ValidUser == false)
                throw new MovieException.MTSException(sb.ToString());
            return ValidUser;
        }

        public static bool CheckUserBL(Users checkuser)
        {
            bool userexists = false;
            try
            {
                userexists = MovieDAL.UserDAL.CheckUserDAL(checkuser);
            }
            catch (MovieException.MTSException e)
            {
                throw e;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return userexists;
        }



        public static bool AddUserBLL(Users newUser, int id)
        {
            bool userAdded = false;
            try
            {

                userAdded = MovieDAL.UserDAL.AddUserDAL(newUser, id);

            }
            catch (MovieException.MTSException e)
            {
                throw e;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return userAdded;
        }




        public static bool UpdateUserBLL(Users updUser)
        {
            bool userUpdated = false;
            try
            {
                userUpdated = MovieDAL.UserDAL.UpdateUserDAL(updUser);
            }
            catch (MovieException.MTSException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return userUpdated;
        }

    }
}
