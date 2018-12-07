using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieDAL;
using MovieEntity;
namespace MovieBLL
{
    public class ScreensBLL
    {


        public static bool ValidateScreen(Screens screens)
        {
            bool IsValid = true;
            StringBuilder sb = new StringBuilder();
            if (screens.ScreenID < 0)
            {
                IsValid = false;
                sb.Append(Environment.NewLine + "Invalid Screen ID");
            }
            if (screens.ScreenName == string.Empty)
            {
                IsValid = false;
                sb.Append(Environment.NewLine + "Invalid Screen Name");
            }
            if(screens.GoldSeats < 0)
            {
                IsValid = false;
                sb.Append(Environment.NewLine + "There should be atleast one Gold Seat.");
            }
            if (screens.SilverSeats < 0)
            {
                IsValid = false;
                sb.Append(Environment.NewLine + "There should be atleast one Silver Seat.");
            }
            if (screens.GoldSeats + screens.SilverSeats != 200)
            {
                IsValid = false;
                sb.Append(Environment.NewLine + "Capacity is 200. Assign Gold seats and Silver seats accordingly.");
            }
            return IsValid;
        }



        public static bool AddScreenBLL(Screens screens)
        {
            bool ScreenAdded = false;
            try
            {
                if (ValidateScreen(screens))
                {
                    ScreenAdded = MovieDAL.ScreensDAL.AddScreensDAL(screens);
                }
            }
            catch(MovieException.MTSException ex)
            {
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return ScreenAdded;
                
        }
        public static List<string> ScreenNameList()
        {
            List<string> screensList = new List<string>();
            try
            {
                screensList = MovieDAL.ScreensDAL.ScreenNameList();
            }
            catch(MovieException.MTSException ex)
            {
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return screensList;
        }


        public static bool UpdateScreenBLL(Screens screens)
        {
            bool ScreenUpdated = false;
            try
            {
                if (ValidateScreen(screens))
                {
                    ScreenUpdated = MovieDAL.ScreensDAL.UpdateScreenDAL(screens);
                }
            }
            catch (MovieException.MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ScreenUpdated;
        }

        public static bool RemoveScreenByNameBLL(String ScreenName)
        {
            bool ScreenRemoved = false;
            try
            {
                ScreenRemoved = MovieDAL.ScreensDAL.DeleteScreenDAL(ScreenName);
            }
            catch(MovieException.MTSException ex)
            {
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return ScreenRemoved;
        }
    }
}
