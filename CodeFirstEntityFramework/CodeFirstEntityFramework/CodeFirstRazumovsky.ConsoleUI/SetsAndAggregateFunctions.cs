using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEntityFramework
{
    public class SetsAndAggregateFunctions
    {
        public void SelectNamesOfAllClientsAndActors()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Actors.Select(act => new { act.Firstname, act.Lastname }).Union(db.Clients.Select(c => new { c.Firstname, c.Lastname }));
                foreach (var row in result)
                    Console.WriteLine($"{row.Firstname},{row.Lastname}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectMoviesWhichStarredByDeNiroAndReno()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = (from starring in db.Starring
                              join actor in db.Actors on starring.ActorId equals actor.ActorId
                              join movie in db.Movies on starring.MovieId equals movie.MovieId
                              where actor.Lastname == "Reno"
                              select movie.Title)
                              .Intersect(
                              from starring in db.Starring
                              join actor in db.Actors on starring.ActorId equals actor.ActorId
                              join movie in db.Movies on starring.MovieId equals movie.MovieId
                              where actor.Lastname == "De Niro"
                              select movie.Title);
                foreach (var row in result)
                    Console.WriteLine($"{row}");
                Console.WriteLine(result.ToQueryString());
            } 
        }
        public void SelectMoviesWhichRentedByGoodspeedAndRentedByGriffin()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = (from rental in db.Rentals
                              join client in db.Clients on rental.ClientId equals client.ClientId
                              join copy in db.Copies on rental.CopyId equals copy.CopyId
                              join movie in db.Movies on copy.MovieId equals movie.MovieId
                              where client.Lastname == "Goodspeed"
                              select movie.Title)
                              .Intersect(
                             from rental in db.Rentals
                             join client in db.Clients on rental.ClientId equals client.ClientId
                             join copy in db.Copies on rental.CopyId equals copy.CopyId
                             join movie in db.Movies on copy.MovieId equals movie.MovieId
                             where client.Lastname == "Griffin"
                             select movie.Title);
                foreach (var row in result)
                    Console.WriteLine($"{row}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectMoviesWhichRentedByGoodspeedAndNeverRentedByGriffin()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = (from rental in db.Rentals 
                              join client in db.Clients on rental.ClientId equals client.ClientId
                              join copy in db.Copies on rental.CopyId equals copy.CopyId
                              join movie in db.Movies on copy.MovieId equals movie.MovieId
                              where client.Lastname=="Goodspeed"
                              select movie.Title)
                              .Except(
                             from rental in db.Rentals
                             join client in db.Clients on rental.ClientId equals client.ClientId
                             join copy in db.Copies on rental.CopyId equals copy.CopyId
                             join movie in db.Movies on copy.MovieId equals movie.MovieId
                             where client.Lastname == "Griffin"
                             select movie.Title);
                foreach (var row in result)
                    Console.WriteLine($"{row}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectActorsWhichPlayedInTerminatorAndNeverPlayedInGhostbusters()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = (from starring in db.Starring
                              join actor in db.Actors on starring.ActorId equals actor.ActorId
                              join movie in db.Movies on starring.MovieId equals movie.MovieId
                              where movie.Title == "Terminator"
                              select actor.Lastname)
                              .Except(
                             from starring in db.Starring
                             join actor in db.Actors on starring.ActorId equals actor.ActorId
                             join movie in db.Movies on starring.MovieId equals movie.MovieId
                             where movie.Title == "Ghostbusters"
                             select actor.Lastname);
                foreach (var row in result)
                    Console.WriteLine($"{row}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectMostExspensiveMovie()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Movies.Select(p=>p.Price);
                var max = result.Max().ToString();
                Console.WriteLine($"{max}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectCountOfMoviesProducedIn1984()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Movies.Where(m => m.Year == 1984);
                Console.WriteLine($"{result}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectCountOfRentalsWhereMovieEqualsTaxiDriver()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = (from starring in db.Starring 
                              join movie in db.Movies on starring.MovieId equals movie.MovieId
                              where movie.Title == "Taxi Driver"
                              select movie.Title);
                Console.WriteLine($"{result.Count()}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void DisplayAveragePriceForEveryYearOfProduction()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Movies.GroupBy(m=>m.Year).Select(m=>new { Year=m.Key, Count=m.Count() });
                foreach (var row in result)
                    Console.WriteLine($"{row.Year},{row.Count}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void AverageRentalTimeForRonin()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = (from rental in db.Rentals 
                              join copy in db.Copies on rental.CopyId equals copy.CopyId
                              join movie in db.Movies on copy.MovieId equals movie.MovieId
                              where movie.Title=="Ronin"
                              select new { Movie=movie, Avg = rental.DateOfReturn.Value - rental.DateOfRental }).ToList().GroupBy(m => m.Movie.Title).Select(g=>g.Average(p=>((DateTime)(new DateTime()+p.Avg)).Ticks));
                foreach (var row in result)
                    Console.WriteLine($"{new DateTime((long)row)}"); 
            }
        }
        public void SelectTitleOfMoviesAndMinRentalTimeAndMaxRentalTimeAndAverageRentalTimeAndCountOfRentalsOrderedByCountOfRentalsDescending()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = (from rental in db.Rentals
                              join copy in db.Copies on rental.CopyId equals copy.CopyId
                              join movie in db.Movies on copy.MovieId equals movie.MovieId
                              where movie.Title == "Ronin"
                              select new { Title = movie.Title, Avg = rental.DateOfReturn.Value - rental.DateOfRental })
                              .ToList()
                              .GroupBy(m => m.Title)
                              .Select(g => new {Title = g.Key,Min=g.Min(p => ((DateTime)(new DateTime() + p.Avg)).Ticks), Max = g.Max(p => ((DateTime)(new DateTime() + p.Avg)).Ticks), Average=g.Average(p => ((DateTime)(new DateTime() + p.Avg)).Ticks) ,Count=g.Count()}).OrderByDescending(m=>m.Count);
                foreach (var row in result)
                    Console.WriteLine($"{row.Title},{new DateTime((long)row.Min)},{new DateTime((long)row.Max)},{new DateTime((long)row.Average)},{row.Count}");
            }
        }
        public void SelectNamesOfClientsAndCountOfTheirRentals()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = (from rental in db.Rentals
                              join client in db.Clients on rental.ClientId equals client.ClientId
                              select new { Client = client, rental.CopyId }).Select(g => new { Name = g.Client.Firstname.Concat(" ").Concat(g.Client.Lastname), CopyId = g.CopyId }).GroupBy(g => g.Name).Select(r => new { Name = r.Key, Count = r.Count() });
                foreach (var row in result)
                    Console.WriteLine($"{row.Name},{row.Count}");
                Console.WriteLine(result.ToQueryString());
            } 
        }
        public void SelectActorsLastnameAndCountOfMoviesWhereTheyStarredSkipActorsWhichWasStarredInOneMovie()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = (from starring in db.Starring
                              join movie in db.Movies on starring.MovieId equals movie.MovieId
                              join actor in db.Actors on starring.ActorId equals actor.ActorId
                              select new { Lastname = actor.Lastname, Count = starring.MovieId }).GroupBy(m=>m.Lastname).Select(r => new { Lastname=r.Key,Count=r.Count() }).Where(g=>g.Count>1).Select(r=>new { Lastname = r.Lastname , Count = r.Count });
                foreach (var row in result)
                    Console.WriteLine($"{row.Lastname},{row.Count}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectClientsLastnameAndAmountOfMoneys()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = (from rental in db.Rentals
                              join client in db.Clients on rental.ClientId equals client.ClientId
                              join copy in db.Copies on rental.CopyId equals copy.CopyId
                              join movie in db.Movies on copy.MovieId equals movie.MovieId
                              select new { Lastname = client.Lastname, Price = movie.Price }).GroupBy(m => m.Lastname).Select(r => new { Lastname = r.Key, Amount=r.Sum(m=>m.Price) });
                foreach (var row in result)
                    Console.WriteLine($"{row.Lastname},{row.Amount}");
                Console.WriteLine(result.ToQueryString());
            }
        }
    }
}
