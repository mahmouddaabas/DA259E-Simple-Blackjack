using DataAccessLayer.Data;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DatabaseManipulation
    {
        DbContextOptionsBuilder options;

        public DatabaseManipulation()
        {
            options = new DbContextOptionsBuilder();
            options.UseSqlServer(@"Data Source=MAHE;Initial Catalog=Blackjack;Integrated Security=True");
        }

        public void addPlayerToDatabase(string playername, int playerscore, string address, string email)
        {
            BlackjackContext context = new BlackjackContext();
            Player player = new Player();
            //player.PlayerId = 10; //id autoincrements in the database no need to insert one
            player.PlayerName = playername;
            context.Add(player);
            context.SaveChanges();

            var player_id = from p in context.Players
                            where p.PlayerName == playername
                            select p.PlayerId; //get the auto generated player id from the database and add it to the other tables (fk).

            Score score = new Score();
            score.ScoreId = player_id.ToList()[0];
            score.PlayerScore = playerscore;
            context.Add(score);
            context.SaveChanges();

            User user = new User();
            user.UserId = player_id.ToList()[0];
            user.Address = address;
            user.Email = email;
            context.Add(user);
            context.SaveChanges();
        }

        public void deletePlayerFromDatabase(int id)
        {
            BlackjackContext context = new BlackjackContext();
            var player = context.Players.FirstOrDefault(player => player.PlayerId == id);
            var score = context.Scores.FirstOrDefault(score => score.ScoreId == id);
            var user = context.Users.FirstOrDefault(user => user.UserId == id);
            context.Users.Remove(user);
            context.Scores.Remove(score);
            context.Players.Remove(player);
            context.SaveChanges();
        }

        public void updatePlayerInDatabase(int playerid, string name, int newscore, string address, string email)
        {
            BlackjackContext context = new BlackjackContext();
            var player = context.Players.FirstOrDefault(player => player.PlayerId == playerid); //get the player from their id
            var score = context.Scores.FirstOrDefault(score => score.ScoreId == playerid);
            var user = context.Users.FirstOrDefault(user => user.UserId == playerid);

            player.PlayerName = name;
            score.PlayerScore = newscore;
            user.Address = address;
            user.Email = email;
            context.SaveChanges();
        }

        public IEnumerable<Player> getPlayers()
        {
            BlackjackContext context = new BlackjackContext();
            //return context.Players;
            var data = context.Players;
            return data;
        }
    }
}
