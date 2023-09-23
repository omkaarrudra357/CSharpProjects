using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieMVC.Models;
using System.Numerics;

namespace MovieMVC.Controllers
{
    public class MovieController : Controller
    {
        // GET: DoctorController1
        public ActionResult Index()
        {
            List<Movie> movie = RepositoryMovie.GetMovies();
            if (movie != null && movie.Count>0)
            {
                return View(movie);
            }
            else
            {
                return RedirectToAction("Create");
            }
        }

        // GET: DoctorController1/Details/5
        public ActionResult Details(int id)
        {
            Movie movie = new Movie();
            return View(movie);
        }

        // GET: DoctorController1/Create
        public ActionResult Create()
        {


            return View();
        }

        // POST: DoctorController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Movie pMovie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryMovie.AddNewMovie(pMovie);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception err)
            {
                return View();
            }
        }

        // GET: DoctorController1/Edit/5
        public ActionResult Edit(int id)
        {
            Movie doctor = RepositoryMovie.GetMovieById(id);
            return View();
        }

        // POST: DoctorController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, Movie movie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryMovie.ModifyMovie(movie);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DoctorController1/Delete/5
        public ActionResult Delete(int id)
        {
            Movie movie = RepositoryMovie.GetMovieById(id);
            return View(movie);
        }

        // POST: DoctorController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryMovie.RemoveMovie(id);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
