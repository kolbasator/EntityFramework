using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        { 
            using(CodeFirstContext db = new CodeFirstContext())
            {
                //LINQ:
                //Selection:
                //Task1:
                //var result = db.Movies.Where(p => p.Year == 1998 || p.Year == 1999);
                //foreach (var movie in result)
                //{
                //    Console.WriteLine($"{movie.Title}");
                //}
                //Console.WriteLine(result.ToQueryString());
                //Task2:
                //var secondResult = db.Movies.Where(p => p.Price > 9);
                //foreach (var movie in secondResult)
                //{
                //    Console.WriteLine($"{movie.Title},{movie.Price}");
                //}
                //Console.WriteLine(secondResult.ToQueryString());
                //Task3:
                //var clients = db.Clients.Where(c => c.Firstname == "Lisa");
                //foreach (var client in clients)
                //{
                //    Console.WriteLine($"{client.Lastname}");
                //}
                //Console.WriteLine(clients.ToQueryString());
                //Task4:
                //var clientsNames = db.Clients.Where(c => c.Firstname.Length + 3 < c.Lastname.Length);
                //foreach (var client in clientsNames)
                //{
                //    Console.WriteLine($"{client.Firstname},{client.Lastname}");
                //}
                //Console.WriteLine(clientsNames.ToQueryString());
                //Task5:
                //var orderedActors = db.Actors.Where(act => act.Firstname == "Arnold" || act.Firstname == "Tom" || act.Firstname == "Jodie").OrderByDescending(act => act.Firstname);
                //foreach (var actor in orderedActors)
                //{
                //    Console.WriteLine($"{actor.Lastname}");
                //}
                //Console.WriteLine(orderedActors.ToQueryString());
                //Task6:
                //var movieIds = db.Movies.Where(m => m.Copies.Any(c => c.Available == true)).Distinct().OrderBy(m => m.MovieId);
                //foreach (var movie in movieIds)
                //{
                //    Console.WriteLine($"{movie.MovieId}");
                //}
                //Console.WriteLine(movieIds.ToQueryString());
                //Task7:
                //var copies = db.Rentals.Where(r => r.DateOfRental > new DateTime(2005, 07, 15) && r.DateOfRental < new DateTime(2005, 07, 22)).Distinct().OrderBy(r => r.CopyId);
                //foreach (var copie in copies)
                //{
                //    Console.WriteLine($"{copie.CopyId}");
                //}
                //Console.WriteLine(movieIds.ToQueryString());
                //Task8:
                //var copiesRentedMoreThanOneDay = db.Rentals.Where(r => (((DateTime)r.DateOfReturn.Value).Day - ((DateTime)r.DateOfRental.Value).Day) > 1);
                //foreach (var rental in copiesRentedMoreThanOneDay)
                //{
                //    Console.WriteLine($"{rental.CopyId},{(((DateTime)rental.DateOfReturn.Value).Day - ((DateTime)rental.DateOfRental.Value).Day)}");
                //}
                //Console.WriteLine(movieIds.ToQueryString());
                //Task9:
                //var actors = db.Actors.Select(p => p.Firstname.ToArray()[0] + "." + p.Lastname);
                //foreach (var actor in actors)
                //{
                //    Console.WriteLine(actor);
                //}
                //Console.WriteLine(actors.ToQueryString());
                //Task10:
                //var orderedMovies = db.Movies.OrderBy(p => p.Title.Length).Select(p => p.Title);
                //foreach (var movie in orderedMovies)
                //{
                //    Console.WriteLine(movie);
                //}
                //Console.WriteLine(orderedMovies.ToQueryString());
                //Task11:
                //var newestMovies = db.Movies.OrderByDescending(p => p.Year).Select(p => new { p.Title, p.Price }).Take(3);
                //foreach (var movie in newestMovies)
                //    Console.WriteLine($"{movie.Title},{movie.Price}");
                //Console.WriteLine(newestMovies.ToQueryString());
                //Task12:
                //var allClientsNames = db.Clients.Select(p => new { p.Firstname, second = p.Firstname.ToArray()[0], third = p.Firstname.ToArray()[p.Firstname.Length - 1] });
                //foreach (var client in allClientsNames)
                //    Console.WriteLine($"{client.Firstname},{client.second},{client.third}");
                //Console.WriteLine(allClientsNames.ToQueryString());
                //Task13:
                //var result2 = db.Clients.Where(p => p.Firstname.ToLower().Substring(p.Firstname.Length - 1, p.Firstname.Length - 1) == p.Firstname.Substring(p.Firstname.Length - 1, p.Firstname.Length - 1)).Select(p => p.Firstname);
                //foreach (var name in result2)
                //    Console.WriteLine(name);
                //Console.WriteLine(result2.ToQueryString());
                //Task14:
                //var oMovies = db.Movies.Where(m => m.Title.Substring(m.Title.Length - 2, m.Title.Length - 2) == "o").Select(m => m.Title);
                //foreach (var title in oMovies)
                //    Console.WriteLine(title);
                //Console.WriteLine(oMovies.ToQueryString());
                //Task15:
                //var emailAddresses = db.Clients.Select(c => c.Firstname.ToLower() + "." + c.Lastname.ToLower() + "@wsb.pl");
                //foreach (var email in emailAddresses)
                //    Console.WriteLine(email);
                //Console.WriteLine(emailAddresses.ToQueryString());
                //Joins:
            }
        }
    }
}
