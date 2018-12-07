using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieDAL;
using MovieEntity;
using MovieException;

namespace MovieBLL
{
    public class AddNewMovieBLL
    {
        public static List<string> GetGenreListBLL()
        {
            return MovieDAL.AddNewMovieDAL.GetGenreListDAL();
        }

        public static int GetGenreIDBLL(string GenreName)
        {
            return MovieDAL.AddNewMovieDAL.GetGenreIDDAL(GenreName);
        }

        public static List<string> GetMoviesListBLL()
        {
            return MovieDAL.AddNewMovieDAL.GetMoviesListDAL();
        }


        public static bool ValidateMovie(Movies movie)
        {
            bool IsValid = true;
            StringBuilder sb = new StringBuilder();
            if (movie.MovieID < 0)
            {
                IsValid = false;
                sb.Append(Environment.NewLine + "Invalid Movie ID");
            }

            if(movie.MovieName==string.Empty)
            {
                IsValid = false;
                sb.Append(Environment.NewLine + "Invalid Movie Name");
            }

            if(movie.ReleaseDate==DateTime.MinValue)
            {
                IsValid = false;
                sb.Append(Environment.NewLine + "Release date cannot be empty");
            }

            if (movie.GenreID==0)
            {
                IsValid = false;
                sb.Append(Environment.NewLine + "Invalid Genre Name");
            }

            if (movie.Description == string.Empty)
            {
                IsValid = false;
                sb.Append(Environment.NewLine + "Description cannot be empty");
            }

            return IsValid;
        }


        public static bool AddMovieBLL(Movies movie)
        {
            bool MovieAdded = false;
            try
            {
                if (ValidateMovie(movie))
                {
                    MovieAdded = MovieDAL.AddNewMovieDAL.AddMovieDAL(movie);
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

            return MovieAdded;
        }

        //public static bool RemoveMovieByNameBLL(string MovieName)
        //{
        //    bool MovieRemoved = false;
        //    try
        //    {
        //        MovieRemoved = MovieDAL.AddMovieDAL.RemoveMovieByNameDAL(MovieName);
        //    }
        //    catch(MovieException.OMTException ex)
        //    {
        //        throw ex;
        //    }
        //    catch(Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return MovieRemoved;
        //}
    }
}
