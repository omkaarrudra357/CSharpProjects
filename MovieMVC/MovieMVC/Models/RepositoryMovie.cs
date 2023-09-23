

namespace MovieMVC.Models
{
    public class RepositoryMovie
    {
        public static List<Movie> GetMovies()
        {
            TestDBContext ctx = new TestDBContext();
            var list = ctx.Movies.ToList();
            return list;        
        }
        public static Movie GetMovieById(int id)
        {
            TestDBContext ctx = new TestDBContext();
            var Movie = ctx.Movies.Find(id);
            return Movie;
        }
        public static void AddNewMovie(Movie movie)
        {
            TestDBContext ctx = new TestDBContext();
            ctx.Movies.Add(movie);
            ctx.SaveChanges();
        }
        public static void ModifyMovie(Movie movie)
        {
            TestDBContext ctx = new TestDBContext();
            ctx.Entry(movie).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ctx.SaveChanges();
        }
        public static void RemoveMovie(int id)
        {
            TestDBContext ctx = new TestDBContext();
            Movie movie = ctx.Movies.Find(id);
            ctx.Movies.Remove(movie);
            ctx.SaveChanges();
        }
    }
}
