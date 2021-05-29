using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic; 

namespace CodeFirstEntityFramework
{
    public class Selection
    {
        public void SelectMoviesWithYear1998Or1999()
        {
            using(CodeFirstContext db=new CodeFirstContext())
            {
                var result = db.Movies.Where(p => p.Year == 1998 || p.Year == 1999);
                foreach (var movie in result) 
                    Console.WriteLine($"{movie.Title}"); 
                Console.WriteLine(result.ToQueryString()); 
            }
        }
        public void SelectMoviesWithPriceGreater9()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Movies.Where(p => p.Price > 9);
                foreach (var movie in result) 
                    Console.WriteLine($"{movie.Title},{movie.Price}"); 
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectClientsWithFirstnameEqualsLisa()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Clients.Where(c => c.Firstname == "Lisa");
                foreach (var client in result) 
                    Console.WriteLine($"{client.Lastname}"); 
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectClientsWhereLastnameLengthGreaterFirstnameLengthMoreBy3()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Clients.Where(c => c.Firstname.Length + 3 < c.Lastname.Length);
                foreach (var client in result) 
                    Console.WriteLine($"{client.Firstname},{client.Lastname}"); 
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectOrderedByDescendingActorsLastnameWithFirstnameEqualsArnoldOrJodieOrTom()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Actors.Where(act => act.Firstname == "Arnold" || act.Firstname == "Tom" || act.Firstname == "Jodie").OrderByDescending(act => act.Firstname);
                foreach (var actor in result) 
                    Console.WriteLine($"{actor.Lastname}"); 
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectDistinctOrderedByMovieIdMoviesWhichCopiesAreAvailable()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Movies.Where(m => m.Copies.Any(c => c.Available == true)).Distinct().OrderBy(m => m.MovieId);
                foreach (var movie in result) 
                    Console.WriteLine($"{movie.MovieId}"); 
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectCopiesCopyIdWhereDataBetween2005_07_15And_2005_07_22()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Rentals.Where(r => r.DateOfRental > new DateTime(2005, 07, 15) && r.DateOfRental < new DateTime(2005, 07, 22)).Distinct().OrderBy(r => r.CopyId);
                foreach (var copie in result) 
                    Console.WriteLine($"{copie.CopyId}"); 
                Console.WriteLine(result.ToQueryString());
            }
        }   
        public void SelectCopiesRentedMoreThenOneDay()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Rentals.Where(r => (((DateTime)r.DateOfReturn.Value).Day - ((DateTime)r.DateOfRental.Value).Day) > 1);
                foreach (var rental in result)
                {
                    Console.WriteLine($"{rental.CopyId},{(((DateTime)rental.DateOfReturn.Value).Day - ((DateTime)rental.DateOfRental.Value).Day)}");
                }
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectActorFirstnameConcatDotConcatActorsLastname()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Actors.Select(p => p.Firstname.ToArray()[0] + "." + p.Lastname);
                foreach (var actor in result) 
                    Console.WriteLine(actor); 
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectMoviesTitleOrderedByTitleLength()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Movies.OrderBy(p => p.Title.Length).Select(p => p.Title);
                foreach (var movie in result) 
                    Console.WriteLine(movie); 
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectNewestMovies()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Movies.OrderByDescending(p => p.Year).Select(p => new { p.Title, p.Price }).Take(3);
                foreach (var movie in result)
                    Console.WriteLine($"{movie.Title},{movie.Price}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectClientsFirstnameAndFirstnameFirstCharAndFirstnameLastChar()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Clients.Select(p => new { p.Firstname, second = p.Firstname.ToArray()[0], third = p.Firstname.ToArray()[p.Firstname.Length - 1] });
                foreach (var client in result)
                    Console.WriteLine($"{client.Firstname},{client.second},{client.third}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectClientsFirstnameWhereFirstCharEqualsLastChar()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Clients.Where(p => p.Firstname.ToLower().Substring(p.Firstname.Length - 1, p.Firstname.Length - 1) == p.Firstname.Substring(p.Firstname.Length - 1, p.Firstname.Length - 1)).Select(p => p.Firstname);
                foreach (var name in result)
                    Console.WriteLine(name);
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectMoviesTitleWhereSecondFromLastCharEqualsO()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Movies.Where(m => m.Title.Substring(m.Title.Length - 2, m.Title.Length - 2) == "o").Select(m => m.Title);
                foreach (var title in result)
                    Console.WriteLine(title);
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectEmailConstructedFromClientsFirstnameAndLastname()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Clients.Select(c => c.Firstname.ToLower() + "." + c.Lastname.ToLower() + "@wsb.pl");
                foreach (var email in result)
                    Console.WriteLine(email);
                Console.WriteLine(result.ToQueryString());
            }
        }
    }
}
