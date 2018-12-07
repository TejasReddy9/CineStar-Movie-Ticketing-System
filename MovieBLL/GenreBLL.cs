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
    public class GenreBLL
    {
        private static bool ValidateGenre(Genre genre)
        {
            StringBuilder sb = new StringBuilder();
            bool validGenre = true;
            if(genre.GenreID < 0)
            {
                validGenre = false;
                sb.Append(Environment.NewLine + "Invalid Genre ID");
            }
            if (genre.GenreName == string.Empty)
            {
                validGenre = false;
                sb.Append(Environment.NewLine + "Invalid GenreName");
            }
            if (genre.Description == string.Empty)
            {
                validGenre = false;
                sb.Append(Environment.NewLine + "Invalid Description");
            }
            if (validGenre == false)
                throw new MovieException.MTSException(sb.ToString());
            return validGenre;
        }
        public static bool AddGenre(Genre newGenre)
        {
            bool genreAdded = false;
            try
            {
                if (ValidateGenre(newGenre))
                {
                    genreAdded = MovieDAL.GenreDAL.AddGenreDAL(newGenre);
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

            return genreAdded;
        }
        public static bool UpdateGenreBL(Genre updateGenre)
        {
            bool genreUpdated = false;
            try
            {
                if (ValidateGenre(updateGenre))
                {
                    MovieDAL.GenreDAL genreDAL = new MovieDAL.GenreDAL();
                    genreUpdated = MovieDAL.GenreDAL.UpdateGenreDAL(updateGenre);
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

            return genreUpdated;
        }

        public static List<int> GetGenreIDBLL()
        {
            List<int> GenreIDList = null;
            try
            {
                GenreIDList = MovieDAL.GenreDAL.GetGenreIdDAL();

            }
            catch (MovieException.MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return GenreIDList;
        }

        public static bool DeleteGenreBL(int deleteGenreID)
        {
            bool genreDeleted = false;
            try
            {
                if (deleteGenreID > 0)
                {
                    genreDeleted = MovieDAL.GenreDAL.DeleteGenreDAL(deleteGenreID);
                }
                else
                {
                    throw new MovieException.MTSException("Invalid Patient ID");
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

            return genreDeleted;
        }

        public static Genre SearchGenreBL(int searchGenreID)
        {
            Genre searchGenre = null;
            try
            {
                searchGenre = MovieDAL.GenreDAL.SearchGenreDAL(searchGenreID);

            }
            catch (MovieException.MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return searchGenre;

        }


    }
}
