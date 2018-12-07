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
    public class UserFeedbackBLL
    {
        private static bool ValidateFeedback(Userfeedback userFeedback)
        {
            bool ValidFeedback = true;
            StringBuilder sb = new StringBuilder();
            if (userFeedback.feedback == string.Empty)
            {
                ValidFeedback = false;
                sb.Append(Environment.NewLine + "Empty Feedbacks aren't allowed");
            }

            if (ValidFeedback == false)
                throw new MovieException.MTSException(sb.ToString());

            return ValidFeedback;
        }

        public static bool AddUserFeedbackBL(Userfeedback newuserfeedback)
        {
            bool feedbackAdded = false;
            try
            {
                if(ValidateFeedback(newuserfeedback))
                    feedbackAdded = MovieDAL.UserFeedbackDAL.AddUserFeedbackDAL(newuserfeedback);
            }
            catch (MovieException.MTSException e)
            {
                throw e;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return feedbackAdded;
        }
        public static List<AdminReport> GetAllUserFeedbackBL()
        {
            List<AdminReport> feedbacklist = null;
            try
            {
                feedbacklist = MovieDAL.UserFeedbackDAL.GetAllFeedbackDAL();

            }
            catch (MovieException.MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return feedbacklist;
        }

    }
}
