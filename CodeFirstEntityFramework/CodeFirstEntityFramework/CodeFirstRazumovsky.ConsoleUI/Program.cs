using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
                Console.WriteLine("Menu:\n1-Selection\n2-Joins\n3-Sets\n4-CRUD");
                var selection = new Selection();
                var sets = new SetsAndAggregateFunctions();
                var joins=new Joins();
                var crud = new CRUD();
                int movie = int.Parse(Console.ReadLine());
                switch (movie)
                {
                    case 1:
                        selection.SelectActorFirstnameConcatDotConcatActorsLastname();
                        Console.ReadLine();
                        selection.SelectClientsFirstnameAndFirstnameFirstCharAndFirstnameLastChar();
                        Console.ReadLine(); 
                        selection.SelectClientsFirstnameWhereFirstCharEqualsLastChar();
                        Console.ReadLine(); 
                        selection.SelectClientsWhereLastnameLengthGreaterFirstnameLengthMoreBy3();
                        Console.ReadLine(); 
                        selection.SelectClientsWithFirstnameEqualsLisa();
                        Console.ReadLine(); 
                        selection.SelectCopiesCopyIdWhereDataBetween2005_07_15And_2005_07_22();
                        Console.ReadLine(); 
                        selection.SelectCopiesRentedMoreThenOneDay();
                        Console.ReadLine(); 
                        selection.SelectDistinctOrderedByMovieIdMoviesWhichCopiesAreAvailable();
                        Console.ReadLine(); 
                        selection.SelectEmailConstructedFromClientsFirstnameAndLastname();
                        Console.ReadLine(); 
                        selection.SelectMoviesTitleOrderedByTitleLength();
                        Console.ReadLine(); 
                        selection.SelectMoviesTitleWhereSecondFromLastCharEqualsO();
                        Console.ReadLine(); 
                        selection.SelectMoviesWithPriceGreater9();
                        Console.ReadLine();
                        selection.SelectMoviesWithYear1998Or1999();
                        Console.ReadLine();
                        selection.SelectNewestMovies();
                        Console.ReadLine();
                        selection.SelectOrderedByDescendingActorsLastnameWithFirstnameEqualsArnoldOrJodieOrTom();
                        Console.ReadLine(); 
                        break;
                    case 2:
                        joins.SelectActorsWhichPlayedInTerminator(); 
                        Console.ReadLine();
                        joins.SelectCopiesJoinMoviesTitle(); 
                        Console.ReadLine();
                        joins.SelectCopiesOfMoviesWhichYearEquals1984();
                        Console.ReadLine();
                        joins.SelectDateOfRentalAndDateOfReturnAndClientName();
                        Console.ReadLine();
                        joins.SelectMoviesWhichCopiesRentedBetween2005_07_15And2005_07_25();
                        Console.ReadLine();
                        joins.SelectMovieWhichWasRentedForLongestTime();
                        Console.ReadLine();
                        joins.SelectNameOfActorAndClientWhereFirstnameOfActorEqualsClientFirstname();
                        Console.ReadLine();
                        joins.SelectNameOfClientsWhoseMadeRentalBetween2005_07_15And2005_07_20();
                        Console.ReadLine();
                        joins.SelectNameOfFirstClient();
                        Console.ReadLine();
                        joins.SelectTitleAndYearOfMoviesRentedByGaryGoodspeed();
                        Console.ReadLine();
                        joins.SelectTitleOfMoviesWhichStarredByRobertDeNiro();
                        Console.ReadLine();
                        joins.SelectTitleOfMoviesWithAvailableCopies();
                        Console.ReadLine();
                        joins.SelectTitleOfMovieWhichCopyWasRentedAndClientName();
                        Console.ReadLine();
                        break;
                    case 3: 
                        sets.DisplayAveragePriceForEveryYearOfProduction();
                        Console.ReadLine();
                        sets.SelectActorsLastnameAndCountOfMoviesWhereTheyStarredSkipActorsWhichWasStarredInOneMovie();
                        Console.ReadLine(); 
                        sets.AverageRentalTimeForRonin();
                        Console.ReadLine();
                        sets.SelectActorsWhichPlayedInTerminatorAndNeverPlayedInGhostbusters();
                        Console.ReadLine();
                        sets.SelectClientsLastnameAndAmountOfMoneys();
                        Console.ReadLine();
                        sets.SelectCountOfMoviesProducedIn1984();
                        Console.ReadLine();
                        sets.SelectCountOfRentalsWhereMovieEqualsTaxiDriver();
                        Console.ReadLine();
                        sets.SelectMostExspensiveMovie();
                        Console.ReadLine();
                        sets.SelectMoviesWhichRentedByGoodspeedAndNeverRentedByGriffin();
                        Console.ReadLine();
                        sets.SelectMoviesWhichRentedByGoodspeedAndRentedByGriffin();
                        Console.ReadLine();
                        sets.SelectMoviesWhichStarredByDeNiroAndReno();
                        Console.ReadLine();
                        sets.SelectNamesOfAllClientsAndActors();
                        Console.ReadLine(); 
                        sets.SelectTitleOfMoviesAndMinRentalTimeAndMaxRentalTimeAndAverageRentalTimeAndCountOfRentalsOrderedByCountOfRentalsDescending();
                        Console.ReadLine();
                        break;
                    case 4:
                        crud.InsertIntoMoviesMadagascar();
                        Console.ReadLine();
                        crud.RemoveMoviesProducedin2005();
                        Console.ReadLine(); 
                        crud.IncreasePriceOfAllMoviesProducedBefore1980By05();
                        Console.ReadLine();
                        crud.InsertIntoMoviesTheIncredibels();
                        Console.ReadLine();
                        crud.DeleteAllMoviesInWhichNoActorsPlayed();
                        Console.ReadLine();
                        crud.SetNewPriceForTaxiDriver();
                        Console.ReadLine();
                        crud.InsertNewCopyOfPlatoon();
                        Console.ReadLine();
                        crud.IncreaseTitleOfMoviesWhichWasRentedMoreThanTwiceBy1();
                        Console.ReadLine();
                        break;
                }
                Console.Clear();
            }
        }
    }
}
