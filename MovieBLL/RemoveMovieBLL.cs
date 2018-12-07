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
    public class RemoveMovieBLL
    {

        public static bool RemoveMovieByNameBLL(string MovieName)
        {
            bool MovieRemoved = false;
            try
            {
                MovieRemoved = MovieDAL.RemoveMovieDAL.RemoveMovieByNameDAL(MovieName);
            }
            catch (MovieException.MTSException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return MovieRemoved;
        }

        
    }
}
