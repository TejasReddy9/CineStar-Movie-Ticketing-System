using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieDAL;
using MovieException;
using MovieEntity;
using System.Text.RegularExpressions;

namespace MovieBLL
{
    public class ViewerBLL
    {
        private static bool ValidateViewer(Viewers viewer)
        {
            StringBuilder sb = new StringBuilder();
            bool validViewer = true;
            if (viewer.FirstName == string.Empty || !Regex.IsMatch(viewer.FirstName,@"^[a-zA-Z]+$"))
            {
                validViewer = false;
                sb.Append(Environment.NewLine + "Invalid FirstName. Try Again!");
            }
            if (viewer.LastName == string.Empty || !Regex.IsMatch(viewer.LastName, @"^[a-zA-Z]+$"))
            {
                validViewer = false;
                sb.Append(Environment.NewLine + "Invalid LastName");
            }
            if (viewer.Mobile == string.Empty || !Regex.IsMatch(viewer.Mobile,@"^\d{10}$"))
            {
                validViewer = false;
                sb.Append(Environment.NewLine + "Mobile number is invalid");
            }
            if (viewer.Email == string.Empty || !Regex.IsMatch(viewer.Email, @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"))
            {
                validViewer = false;
                sb.Append(Environment.NewLine + "Invalid Email");
            }
            if (viewer.UserName == string.Empty)
            {
                validViewer = false;
                sb.Append(Environment.NewLine + "UserName can not be empty");
            }
            if (viewer.Password == string.Empty)
            {
                validViewer = false;
                sb.Append(Environment.NewLine + "Create a Password");
            }
            if (validViewer == false)
                throw new MovieException.MTSException(sb.ToString());
            return validViewer;
        }

        public static bool AddViewer(Viewers newViewer)
        {
            bool viewerAdded = false;
            try
            {
                if (ValidateViewer(newViewer))
                {
                    viewerAdded = MovieDAL.ViewerDAL.AddViewerDAL(newViewer);
                }
            }
            catch (MovieException.MTSException e)
            {
                throw e;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return viewerAdded;
        }

        public static bool UpdateViewerBL(Viewers updViewer)
        {
            bool viewerUpdated = false;
            try
            {
                if (ValidateViewer(updViewer))
                {

                    viewerUpdated = MovieDAL.ViewerDAL.UpdateViewerDAL(updViewer);

                }
            }
            catch (MovieException.MTSException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return viewerUpdated;
        }
        public static Viewers SearchViewersBL(int searchViewersID)
        {
            Viewers searchViewers = null;
            try
            {
                searchViewers = ViewerDAL.SearchViewersDAL(searchViewersID);
            }
            catch (MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return searchViewers;

        }
    }
}
