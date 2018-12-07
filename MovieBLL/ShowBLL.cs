using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieEntity;
using MovieException;
using MovieDAL;

namespace MovieBLL
{
    public class ShowBLL
    {

        private static bool ValidateShow(Shows newShow)
        {
            StringBuilder sb = new StringBuilder();
            bool validShow = true;
            if (newShow.ScreenID < 0)
            {
                validShow = false;
                sb.Append(Environment.NewLine + "Invalid Screen ID");
            }
            if(newShow.ShowID < 0)
            {
                validShow = false;
                sb.Append(Environment.NewLine + "Invalid Show ID");
            }
            if (newShow.ShowDate == DateTime.MinValue)
            {
                validShow = false;
                sb.Append(Environment.NewLine + "Show Date can't be empty");
            }
            if (newShow.MovieID < 0)
            {
                validShow = false;
                sb.Append(Environment.NewLine + "Invalid Movie ID");
            }
            //if (!(newShow.GoldPrice == 180 || newShow.GoldPrice == 200 || newShow.GoldPrice == 220))
            //{
            //    validShow = false;
            //    sb.Append(Environment.NewLine + "Valid Gold Ticket Prices: 180, 200, 220");
            //}
            //if (!(newShow.SilverPrice == 75 || newShow.SilverPrice == 100 || newShow.SilverPrice == 125))
            //{
            //    validShow = false;
            //    sb.Append(Environment.NewLine + "Valid Silver Ticket Prices: 75, 100, 125");
            //}
            if (newShow.ShowSlot == string.Empty)
            {
                validShow = false;
                sb.Append(Environment.NewLine + "Empty Show Slot");
            }

            if (validShow == false)
                throw new MovieException.MTSException(sb.ToString());
            return validShow;
        }

        public static List<int> GetScreenIdBLL()
        {
            List<int> ScreenIdList = null;
            try
            {
                ScreenIdList = MovieDAL.ShowDAL.GetScreenID();
            }
            catch (MovieException.MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ScreenIdList;
        }

        public static List<string> GetMovieNameBLL()
        {
            List<string> MovieNameList = null;
            try
            {
                MovieNameList = MovieDAL.ShowDAL.GetMovieName();
            }
            catch (MovieException.MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return MovieNameList;
        }


        public static DateTime GetReleasedateBLL(string MovieName)
        {
            DateTime Releasedate = new DateTime();
            try
            {
                Releasedate = MovieDAL.ShowDAL.GetReleaseDate(MovieName);
            }
            catch (MovieException.MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Releasedate;
        }


        public static List<string> SlotsBLL(int screenId, DateTime da)
        {
            List<string> slots;
            try
            {
                slots = MovieDAL.ShowDAL.GetSlots(screenId, da);
            }
            catch (MovieException.MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return slots;

        }
        

        public static bool AddShowBLL(Shows newShow, string MovieName)
        {
            bool showAdded = false;
            try
            {
                if (ValidateShow(newShow))
                {
                    showAdded = MovieDAL.ShowDAL.AddShowDAL(newShow, MovieName);
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

            return showAdded;
        }



        public static List<MovieShowDetails> GetAllShowsBLL()
        {
            List<MovieShowDetails> ShowsList = null;
            try
            {
                ShowsList = MovieDAL.ShowDAL.GetAllShowsDAL();
            }
            catch (MovieException.MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ShowsList;
        }
    }
}
