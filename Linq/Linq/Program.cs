using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            using (LinqSportContext context = new LinqSportContext())
            {
                /*
                var team1 = new Team
                {
                    Name = "Olimp"
                };
                context.Teams.Add(team1);

                var player1 = new Player
                {
                    Name = "Vadim",
                    Number = 12,
                    Team = team1
                };
                context.Players.Add(player1);

                context.SaveChanges();
                

                var player2 = new Player
                {
                    Name = "asdasd",
                    Number = 1,
                    TeamId=1
                };
                context.Players.Add(player2);

                context.SaveChanges();*/
                
                var players = from Players in context.Players
                              where Players.Name == "Vadim"
                              select Players;

                Player playerSearch = players.FirstOrDefault();

                Console.WriteLine("Результаты поиска:");
                Console.WriteLine("Имя: "+playerSearch.Name + "\nНомер: " + playerSearch.Number + "\nId команды: " + playerSearch.TeamId);
                Console.ReadLine();
            }
        }
    }
}
