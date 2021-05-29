using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEntityFramework
{
    public class Joins
    {
        public void SelectCopiesJoinMoviesTitle()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Copies.Join(db.Movies,
                     p => p.MovieId,
                     c => c.MovieId,
                    (p, c) => new
                    {
                        CopyId = p.CopyId,
                        Title = c.Title
                    });
                foreach (var row in result)
                    Console.WriteLine($"{row.CopyId},{row.Title}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectTitleOfMoviesWithAvailableCopies()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Movies.Join(db.Copies,
                    m => m.MovieId,
                    c => c.MovieId,
                    (m, c) => new
                    {
                        Title = m.Title,
                        Available = c.Available
                    }).Where(r => r.Available == true).Select(r => r.Title).Distinct();
                foreach (var row in result)
                    Console.WriteLine($"{row}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectCopiesOfMoviesWhichYearEquals1984()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Movies.Join(db.Copies,
                    m => m.MovieId,
                    c => c.MovieId,
                    (m, c) => new
                    {
                        CopyId = c.CopyId,
                        Year = m.Year
                    }).Where(r => r.Year == 1984).Select(r => r.CopyId);
                foreach (var row in result)
                    Console.WriteLine($"{row}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectDateOfRentalAndDateOfReturnAndClientName()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Rentals.Join(db.Clients,
                    r => r.ClientId,
                    c => c.ClientId,
                    (r, c) => new
                    {
                        DateOfRental = r.DateOfRental,
                        DateOfReturn = r.DateOfReturn,
                        Lastname = c.Lastname
                    });
                foreach (var row in result)
                    Console.WriteLine($"{row.DateOfRental},{row.DateOfReturn},{row.Lastname}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectTitleOfMovieWhichCopyWasRentedAndClientName()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = db.Rentals.Join(db.Clients,
                    r => r.ClientId,
                    c => c.ClientId,
                    (r, c) => new
                    {
                        Lastname = c.Lastname,
                        CopyId = r.CopyId
                    })
                    .Join(db.Copies,
                    r => r.CopyId,
                    c => c.CopyId,
                    (r, c) => new
                    {
                        Lastname = r.Lastname,
                        CopyId = c.CopyId,
                        MovieId = c.MovieId
                    })
                    .Join(db.Movies,
                    c => c.MovieId,
                    m => m.MovieId,
                    (c, m) => new
                    {
                        Lastname = c.Lastname,
                        Title = m.Title
                    });
                foreach (var row in result)
                    Console.WriteLine($"{row.Lastname},{row.Title}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectTitleAndYearOfMoviesRentedByGaryGoodspeed()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = from rental in db.Rentals
                             join client in db.Clients on rental.ClientId equals client.ClientId
                             join copy in db.Copies on rental.CopyId equals copy.CopyId
                             join movie in db.Movies on copy.MovieId equals movie.MovieId
                             where client.Lastname == "Goodspeed"
                             select new
                             {
                                 Title = movie.Title,
                                 Year = movie.Year
                             };
                foreach (var row in result)
                    Console.WriteLine($"{row.Title},{row.Year}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectNameOfFirstClient()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = (from rental in db.Rentals
                             join client in db.Clients on rental.ClientId equals client.ClientId
                             join copy in db.Copies on rental.CopyId equals copy.CopyId
                             join movie in db.Movies on copy.MovieId equals movie.MovieId  
                             select new
                             {
                                 Firstname=client.Firstname,
                                 Lastname=client.Lastname
                             }).Take(1);
                foreach (var row in result)
                    Console.WriteLine($"{row.Firstname},{row.Lastname}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectActorsWhichPlayedInTerminator()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = from starring in db.Starring
                             join actor in db.Actors on starring.ActorId equals actor.ActorId
                             join movie in db.Movies on starring.MovieId equals movie.MovieId
                             where movie.Title == "Terminator"
                             select actor.Lastname;
                foreach (var row in result)
                    Console.WriteLine($"{row}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectTitleOfMoviesWhichStarredByRobertDeNiro()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = from starring in db.Starring
                             join actor in db.Actors on starring.ActorId equals actor.ActorId
                             join movie in db.Movies on starring.MovieId equals movie.MovieId
                             where actor.Firstname=="Robert"
                             select movie.Title;
                foreach (var row in result)
                    Console.WriteLine($"{row}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectMovieWhichWasRentedForLongestTime()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = (from rental in db.Rentals
                              join copy in db.Copies on rental.CopyId equals copy.CopyId
                              join movie in db.Movies on copy.MovieId equals movie.MovieId
                              orderby ((DateTime)rental.DateOfReturn.Value).Day - ((DateTime)rental.DateOfRental.Value).Day descending
                              select movie.Title).Take(1);
                foreach (var row in result)
                    Console.WriteLine($"{row}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectNameOfClientsWhoseMadeRentalBetween2005_07_15And2005_07_20()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = (from rental in db.Rentals
                             join client in db.Clients on rental.ClientId equals client.ClientId
                             where rental.DateOfRental > new DateTime(2005, 07, 15) && rental.DateOfRental < new DateTime(2005, 07, 20)
                             select client.Lastname).Distinct();
                foreach (var row in result)
                    Console.WriteLine($"{row}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectMoviesWhichCopiesRentedBetween2005_07_15And2005_07_25()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = (from rental in db.Rentals
                              join copy in db.Copies on rental.CopyId equals copy.CopyId
                              join movie in db.Movies on copy.MovieId equals movie.MovieId
                              where rental.DateOfRental > new DateTime(2005, 07, 15) && rental.DateOfRental < new DateTime(2005, 07, 25)
                              select movie.Title).Distinct();
                foreach (var row in result)
                    Console.WriteLine($"{row}");
                Console.WriteLine(result.ToQueryString());
            }
        }
        public void SelectNameOfActorAndClientWhereFirstnameOfActorEqualsClientFirstname()
        {
            using (CodeFirstContext db = new CodeFirstContext())
            {
                var result = from actor in db.Actors
                             join client in db.Clients on actor.Firstname equals client.Firstname
                             select new
                             {
                                 Firstname = client.Firstname,
                                 Actor = actor.Lastname,
                                 Client = client.Lastname
                             };
                foreach (var row in result)
                    Console.WriteLine($"{row.Firstname},{row.Actor},{row.Client}");
                Console.WriteLine(result.ToQueryString());
            }
        }
    }
}
