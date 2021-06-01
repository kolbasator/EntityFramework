using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CodeFirstEntityFramework
{
    public class CRUD
    {       
        public void InsertIntoMoviesMadagascar()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                db.Movies.Add(new Movie { MovieId = 11, Title = "Madagascar", Year = 2005,AgeRestriction=0, Price = 10.5f });
                db.SaveChanges();
                foreach (var row in db.Movies)
                    Console.WriteLine($"{row.MovieId},{row.Title},{row.Year},{row.AgeRestriction},{row.Price}"); 
            }
        }
        public void RemoveMoviesProducedin2005()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var moviesToRemove = db.Movies.Where(m => m.Year == 2005);
                db.Movies.RemoveRange(moviesToRemove);
                db.SaveChanges();
                foreach (var row in db.Movies)
                    Console.WriteLine($"{row.MovieId},{row.Title},{row.Year},{row.AgeRestriction},{row.Price}");
            }
        }
        public void IncreasePriceOfAllMoviesProducedBefore1980By05()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                foreach (var movie in db.Movies.Where(m => m.Year < 1980))
                    movie.Price = movie.Price + 0.5f;
                db.SaveChanges();
                foreach (var row in db.Movies)
                    Console.WriteLine($"{row.MovieId},{row.Title},{row.Year},{row.AgeRestriction},{row.Price}");
            }
        }
        public void InsertIntoMoviesTheIncredibels()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                db.Movies.Add(new Movie { MovieId = 12, Title = "The Incredibles", Year = 2004, AgeRestriction = 0, Price =9.5f });
                db.SaveChanges();
                foreach (var row in db.Movies)
                    Console.WriteLine($"{row.MovieId},{row.Title},{row.Year},{row.AgeRestriction},{row.Price}");
            }
        }
        public void DeleteAllMoviesInWhichNoActorsPlayed()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var moviestoDelete = db.Movies.Where(k=>db.Starring.Any(m=>m.MovieId!=k.MovieId));
                db.SaveChanges();
                foreach (var row in db.Movies)
                    Console.WriteLine($"{row.MovieId},{row.Title},{row.Year},{row.AgeRestriction},{row.Price}");
            }
        }
        public void SetNewPriceForTaxiDriver()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var movie = db.Movies.Where(m => m.Title == "Taxi Driver").FirstOrDefault();
                movie.Price = 5;
                db.SaveChanges();
                foreach (var row in db.Movies)
                    Console.WriteLine($"{row.MovieId},{row.Title},{row.Year},{row.AgeRestriction},{row.Price}");
            }
        }
        public void IncreaseTitleOfMoviesWhichWasRentedMoreThanTwiceBy1()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                //var movies = (from copy in db.Copies
                //              join movie in db.Movies on copy.MovieId equals movie.MovieId
                //              select new { , copy.CopyId })
                //foreach (var movie in movies)
                //    movie. = movie.Price + 1f;
                //db.SaveChanges();
                //foreach (var row in db.Movies)
                //    Console.WriteLine($"{row.MovieId},{row.Title},{row.Year},{row.AgeRestriction},{row.Price}"); 
            }
        }
        public void InsertNewCopyOfPlatoon()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                db.Copies.Add(new Copy { CopyId = db.Copies.Select(c => c.CopyId).Max() + 1, Available = true, MovieId = db.Movies.Where(m => m.Title == "Platoon").Select(m => m.MovieId).FirstOrDefault() });
                db.SaveChanges();
                foreach (var row in db.Movies)
                    Console.WriteLine($"{row.MovieId},{row.Title},{row.Year},{row.AgeRestriction},{row.Price}");
            }
        }
    }
}
