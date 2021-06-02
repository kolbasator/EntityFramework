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
            using (var db = new CodeFirstContext())
            {
                db.Movies.Add(new Movie { MovieId = 11, Title = "Madagascar", Year = 2005,AgeRestriction=0, Price = 10.5f });
                db.SaveChanges();
                foreach (var row in db.Movies)
                {
                    Console.WriteLine(row.ToString());
                }
            }
        }
        public void RemoveMoviesProducedin2005()
        {
            using (var db = new CodeFirstContext())
            {
                var moviesToRemove = db.Movies.Where(m => m.Year == 2005);
                db.Movies.RemoveRange(moviesToRemove);
                db.SaveChanges();
                foreach (var row in db.Movies)
                {
                    Console.WriteLine(row.ToString());
                }
            }
        }
        public void IncreasePriceOfAllMoviesProducedBefore1980By05()
        {
            using (var db = new CodeFirstContext())
            {
                foreach (var movie in db.Movies.Where(m => m.Year < 1980))
                    movie.Price = movie.Price + 0.5f;
                db.SaveChanges();
                foreach (var row in db.Movies)
                {
                    Console.WriteLine(row.ToString());
                }
            }
        }
        public void InsertIntoMoviesTheIncredibels()
        {
            using (var db = new CodeFirstContext())
            {
                db.Movies.Add(new Movie { MovieId = 12, Title = "The Incredibles", Year = 2004, AgeRestriction = 0, Price =9.5f });
                db.SaveChanges();
                foreach (var row in db.Movies)
                {
                    Console.WriteLine(row.ToString());
                } 
            }
        }
        public void DeleteAllMoviesInWhichNoActorsPlayed()
        {
            using (var db = new CodeFirstContext())
            {
                var moviestoDelete = db.Movies.Where(k=>db.Starring.Any(m=>m.MovieId!=k.MovieId));
                db.SaveChanges();
                foreach (var row in db.Movies)
                {
                    Console.WriteLine(row.ToString());
                }
            }
        }
        public void SetNewPriceForTaxiDriver()
        {
            using (var db = new CodeFirstContext())
            {
                var movie = db.Movies.Where(m => m.Title == "Taxi Driver").FirstOrDefault();
                movie.Price = 5;
                db.SaveChanges();
                foreach (var row in db.Movies)
                {
                    Console.WriteLine(row.ToString());
                }
            }
        }
        public void IncreaseTitleOfMoviesWhichWasRentedMoreThanTwiceBy1()
        {
            using (var db = new CodeFirstContext())
            {
                var movies = (from copy in db.Copies
                              join rental in db.Rentals on copy.CopyId equals rental.CopyId
                              join movie in db.Movies on copy.MovieId equals movie.MovieId
                              group copy by movie.MovieId into g
                              select new
                              {
                                  MovieId = g.Key,
                                  Count = g.Count()
                              });
                foreach (var movie in db.Movies) 
                {
                    if (movies.Any(m => m.MovieId == movie.MovieId))
                    {
                        movie.Price = movie.Price + 1f;
                    }
                }
                db.SaveChanges();
                foreach (var row in db.Movies)
                {
                    Console.WriteLine(row.ToString());
                }
            }
        }
        public void InsertNewCopyOfPlatoon()
        {
            using (var db = new CodeFirstContext())
            {
                db.Copies.Add(new Copy { CopyId = db.Copies.Select(c => c.CopyId).Max() + 1, Available = true, MovieId = db.Movies.Where(m => m.Title == "Platoon").Select(m => m.MovieId).FirstOrDefault() });
                db.SaveChanges();
                foreach (var row in db.Movies)
                {
                    Console.WriteLine(row.ToString());
                }
            }
        }
    }
}
