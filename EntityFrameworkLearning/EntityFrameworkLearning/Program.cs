using System;
using System.Linq;

namespace EntityFrameworkLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SimpleSocialNetworkContext db = new SimpleSocialNetworkContext())
            {
                //    Basics:
                ////NetworkUser user1 = new NetworkUser { Age = 21, Username = "Tom", Email = "Tom1@gmail.com", Password = "tom12345" };
                ////NetworkUser user2 = new NetworkUser { Age = 18, Username = "Liam", Email = "Liam2@gmail.com", Password = "YDiRcwjp6n4EWYsP6YrT" };
                ////NetworkUser user3 = new NetworkUser { Age = 56, Username = "Emily", Email = "Emily3@gmail.com", Password = "RkmmB8tF" };
                ////NetworkUser user4 = new NetworkUser { Age = 87, Username = "Charlotte", Email = "Charlotte4@gmail.com", Password = "vpUZWQX9" };
                ////NetworkUser user5 = new NetworkUser { Age = 67, Username = "Gabriel", Email = "Gabriel5@gmail.com", Password = "lolkek" };
                ////NetworkUser user6 = new NetworkUser { Age = 25, Username = "Louise", Email = "Louise6@gmail.com", Password = "HDf5K78" };
                ////NetworkUser user7 = new NetworkUser { Age = 44, Username = "Noah", Email = "Noah7@gmail.com", Password = "KjHgFd48G999" };
                ////NetworkUser user8 = new NetworkUser { Age = 11, Username = "Sofia", Email = "Sofia8@gmail.com", Password = "JKLour890" };
                ////NetworkUser user9 = new NetworkUser { Age = 32, Username = "Alice", Email = "Alice9@gmail.com", Password = "YrETWE9I0" };
                ////NetworkUser user10 = new NetworkUser { Age = 15, Username = "Maria", Email = "Maria101@gmail.com", Password = "KlJKgn&895HG" };
                ////NetworkUser razumovsky = new NetworkUser { Age = 27, Username = "Razumovsky_R", Email = "kolosovpetro@gmail.com", Password = "yFUHHrZp2L6crdRxBAXB" };
                ////NetworkUser musyaka = new NetworkUser { Age = 12, Username = "MusyakaKolbasator", Email = "kolbastor@gmail.com", Password = "RazumovskyTop" };
                ////Post post1 = new Post { UserId = 1, Content = "I am Tom." };
                ////Post post2 = new Post { UserId = 2, Content = "I am Liam." };
                ////Post post3 = new Post { UserId = 3, Content = "I am Emily." };
                ////Post post4 = new Post { UserId = 4, Content = "I am Charlotte." };
                ////Post post5 = new Post { UserId = 5, Content = "I am Gabriel." };
                ////Post post6 = new Post { UserId = 6, Content = "I am Louise." };
                ////Post post7 = new Post { UserId = 7, Content = "I am Noah." };
                ////Post post8 = new Post { UserId = 8, Content = "I am Sofia." };
                ////Post post9 = new Post { UserId = 9, Content = "I am Alice." };
                ////Post post10 = new Post { UserId = 10, Content = "I am Maria." };
                ////Post razumovskyPost = new Post { UserId = 11, Content = "Мусяка лох.Сообщение для него:у тебя уже уровень второго курса универа просто . ну уровень заданий.тем не менее, это не уровено джуна и даже не уровенль стажера.это очень низкий уровень." };
                ////Post musyakaPost = new Post { UserId = 12, Content = "Хочу пиццу и биг воппер и кока колу." }; 
                ////db.NetworkUsers.Add(user1);
                ////db.NetworkUsers.Add(user2);
                ////db.NetworkUsers.Add(user3);
                ////db.NetworkUsers.Add(user1);
                ////db.NetworkUsers.Add(user4);
                ////db.NetworkUsers.Add(user5);
                ////db.NetworkUsers.Add(user6);
                ////db.NetworkUsers.Add(user7);
                ////db.NetworkUsers.Add(user8);
                ////db.NetworkUsers.Add(user9);
                ////db.NetworkUsers.Add(user10);
                ////db.NetworkUsers.Add(razumovsky);
                ////db.NetworkUsers.Add(musyaka);
                ////db.Posts.Add(post1);
                ////db.Posts.Add(post2);
                ////db.Posts.Add(post3);
                ////db.Posts.Add(post4);
                ////db.Posts.Add(post5);
                ////db.Posts.Add(post6);
                ////db.Posts.Add(post7);
                ////db.Posts.Add(post8);
                ////db.Posts.Add(post9);
                ////db.Posts.Add(post10);
                ////db.Posts.Add(razumovskyPost);
                ////db.Posts.Add(musyakaPost);
                ////db.SaveChanges();
                ////foreach(var user in db.NetworkUsers)
                ////{
                ////    Console.WriteLine($"ID-{user.NetworkUserId},Age-{user.Age},Username-{user.Username},Email-{user.Email},Password-{user.Password}\n");
                ////}
                ////Console.Read();
                ////foreach(var post in db.Posts)
                ////{
                ////    Console.WriteLine($"Post ID-{post.PostId},User ID-{post.UserId},Content-'{post.Content}'\n");
                ////}
                ////Console.Read();
                ///CRUD : 
                ///Create :
                //db.NetworkUsers.Add(new NetworkUser { NetworkUserId = 13, Age = 20, Username = "Dungeoun Master", Email = "dungeonmaster@gmail.com", Password = "lolkek709" });
                //db.NetworkUsers.Add(new NetworkUser { NetworkUserId = 14, Age = 30, Username = "Egor", Email = "egorich@gmail.com", Password = "sosiska9" });
                //db.NetworkUsers.Add(new NetworkUser { NetworkUserId = 15, Age = 80, Username = "GC", Email = "ded@gmail.com", Password = "yagovno" });
                //db.Posts.Add(new Post { PostId = 13, UserId = 13, Content = "Razumovsky Top!" });
                //db.Posts.Add(new Post { PostId = 14, UserId = 12, Content = "Razumovsky Top!" });
                //db.Posts.Add(new Post { PostId = 15, UserId = 12, Content = "Razumovsky Top!" });
                //Console.Read();
                //db.SaveChanges();
                //foreach (var post in db.Posts)
                //{
                //    Console.WriteLine($"Post ID-{post.PostId},User ID-{post.UserId},Content-'{post.Content}'\n");
                //}
                //foreach (var user in db.NetworkUsers)
                //{
                //    Console.WriteLine($"ID-{user.NetworkUserId},Age-{user.Age},Username-{user.Username},Email-{user.Email},Password-{user.Password}\n");
                //}
                //Read:
                //foreach (var post in db.Posts)
                //{
                //    Console.WriteLine($"Post ID-{post.PostId},User ID-{post.UserId},Content-'{post.Content}'\n");
                //}
                //foreach (var user in db.NetworkUsers)
                //{
                //    Console.WriteLine($"ID-{user.NetworkUserId},Age-{user.Age},Username-{user.Username},Email-{user.Email},Password-{user.Password}\n");
                //}
                ////Update:
                //var razumovskyr = db.NetworkUsers.Where(c => c.Username == "Razumovsky_R").FirstOrDefault();
                //razumovskyr.Email = "razumovskyr@gmail.com";
                //var kolbasator = db.NetworkUsers.Where(c => c.Username == "MusyakaKolbasator").FirstOrDefault();
                //kolbasator.Email = "musyakakolbasyaka@gmail.com";
                //var dungeonmaster = db.NetworkUsers.Where(c => c.Username == "Dungeoun Master").FirstOrDefault();
                ////dungeonmaster.Email = "master@gmail.com";
                ////db.SaveChanges();
                ////foreach (var user in db.NetworkUsers)
                ////{
                ////    Console.WriteLine($"ID-{user.NetworkUserId},Age-{user.Age},Username-{user.Username},Email-{user.Email},Password-{user.Password}\n");
                ////}
                //Delete:
                //var razumovskyr1 = db.NetworkUsers.Where(c => c.Username == "Razumovsky_R").FirstOrDefault(); 
                //var kolbasator1 = db.NetworkUsers.Where(c => c.Username == "MusyakaKolbasator").FirstOrDefault(); 
                ////var dungeonmaster1 = db.NetworkUsers.Where(c => c.Username == "Dungeoun Master").FirstOrDefault();
                ////db.Remove(razumovskyr1);
                ////db.Remove(kolbasator1);
                ////db.Remove(dungeonmaster1); 
                ////db.SaveChanges();
                //foreach (var user in db.NetworkUsers)
                //{
                //    Console.WriteLine($"ID-{user.NetworkUserId},Age-{user.Age},Username-{user.Username},Email-{user.Email},Password-{user.Password}\n");
                //}
            }
        }
    }
}
