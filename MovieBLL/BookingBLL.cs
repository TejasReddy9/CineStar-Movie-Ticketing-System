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
    public class BookingBLL
    {
        public static List<string> GetGenreNameBLL()
        {
            List<string> GenreNameList = null;
            try
            {
                GenreNameList = MovieDAL.BookingDAL.GetAllGenreDAL();
            }
            catch (MovieException.MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return GenreNameList;
        }
        
        public static List<string> GetAllMoviesBLL()
        {
            List<string> MovieNameList = null;
            try
            {
                MovieNameList = MovieDAL.BookingDAL.GetAllMovieDAL();
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



        public static List<string> GetMovieWithGenreBLL(string GenreName)
        {
            List<string> MovieNameList = null;
            try
            {
                MovieNameList = MovieDAL.BookingDAL.GetMovieFromGenreDAL(GenreName);
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



        public static List<DateTime> GetAvailableDatesBLL(string MovieName)
        {
            List<DateTime> GetDates = null;
            try
            {
                GetDates = MovieDAL.BookingDAL.GetAvailableDates(MovieName);
            }
            catch (MovieException.MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return GetDates;
        }

        public static List<BookingClass> GetGridBLL(DateTime date, string MovieName)
        {
            List<BookingClass> GridList = null;
            try
            {
                GridList = MovieDAL.BookingDAL.GetAvailableGridDAL(date, MovieName);
            }
            catch (MovieException.MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return GridList;
        }


        public static List<int> GetGrid_screenID_BLL(DateTime date, string MovieName)
        {
            List<int> ScreenIDList = null;
            try
            {
                ScreenIDList = MovieDAL.BookingDAL.GetAvailableGrid_ScreenID_DAL(date, MovieName);
            }
            catch (MovieException.MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ScreenIDList;
        }


        public static List<string> GetSlot_screenID_BLL(DateTime date, string MovieName, int id)
        {
            List<string> ScreenIDList = null;
            try
            {
                ScreenIDList = MovieDAL.BookingDAL.Get_Slot_ScreenID_DAL(date, MovieName, id);
            }
            catch (MovieException.MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ScreenIDList;
        }



        public static int GetGoldSeatsFromGRID(int ScreenId, string MovieName, string showSlot, DateTime date)
        {
            int GoldSeats = 0;
            try
            {
                GoldSeats = MovieDAL.BookingDAL.GetGoldSeats_Grid_DAL(ScreenId, MovieName, showSlot, date);
            }
            catch (MovieException.MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return GoldSeats;
        }


        public static int GetSilverSeatsFromGRID(int ScreenId, string MovieName, string showSlot, DateTime date)
        {
            int SilverSeats = 0;
            try
            {
                SilverSeats = MovieDAL.BookingDAL.GetSilverSeats_Grid_DAL(ScreenId, MovieName, showSlot, date);
            }
            catch (MovieException.MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return SilverSeats;
        }

        public static int GetGoldPriceFromGRID(int ScreenId, string MovieName, string showSlot, DateTime date)
        {
            int GoldPrice = 0;
            try
            {
                GoldPrice = MovieDAL.BookingDAL.GetGoldPRICE_Grid_DAL(ScreenId, MovieName, showSlot, date);
            }
            catch (MovieException.MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return GoldPrice;
        }


        public static int GetSilverPriceFromGRID(int ScreenId, string MovieName, string showSlot, DateTime date)
        {
            int SilverPrice = 0;
            try
            {
                SilverPrice = MovieDAL.BookingDAL.GetSilverPRICE_Grid_DAL(ScreenId, MovieName, showSlot, date);
            }
            catch (MovieException.MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return SilverPrice;
        }


        public static int GetShowID(int ScreenId, string MovieName, string showSlot, DateTime date)
        {
            int ShowID = 0;
            try
            {
                ShowID = MovieDAL.BookingDAL.GetShowID_DAL(ScreenId, MovieName, showSlot, date);
            }
            catch (MovieException.MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ShowID;
        }



        public static bool AddTicketBLL(Tickets newTicket, int ScreenId, string MovieName, string showSlot, DateTime date)
        {
            bool TicketAdded = false;
            try
            {

                TicketAdded = MovieDAL.BookingDAL.AddTicketDAL(newTicket, ScreenId, MovieName, showSlot, date);

            }
            catch (MovieException.MTSException e)
            {
                throw e;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return TicketAdded;
        }



        public static bool UpdateGoldSeatBLL(int ScreenId, string MovieName, string showSlot, DateTime date, int BookingCount)
        {
            bool GoldUpdated = false;
            try
            {

                GoldUpdated = MovieDAL.BookingDAL.UpdateGoldSeatCountDAL(ScreenId, MovieName, showSlot, date, BookingCount);

            }
            catch (MovieException.MTSException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return GoldUpdated;
        }



        public static bool UpdateSilverSeatBLL(int ScreenId, string MovieName, string showSlot, DateTime date, int BookingCount)
        {
            bool SilverUpdated = false;
            try
            {

                SilverUpdated = MovieDAL.BookingDAL.UpdateSilverSeatCountDAL(ScreenId, MovieName, showSlot, date, BookingCount);

            }
            catch (MovieException.MTSException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return SilverUpdated;
        }


    }




}
