using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.Models;
using GameCardLib;

namespace SimpleBlackjack
{
    public partial class PlayerForm : Form
    {
        private GameController gc;
        public PlayerForm(GameController gc)
        {
            InitializeComponent();
            this.gc = gc;
            loadPlayersFromDB();
        }

        public void loadPlayersFromDB()
        {
            //splayers_datagrid.DataSource = gc.getAllPlayers().ToList();
            //players_datagrid.DataSource = gc.getContext().Players.ToList();

            var context = gc.getContext();
            var query = from players in context.Players
                        join score in context.Scores
                        on players.PlayerId equals score.ScoreId
                        join users in context.Users
                        on score.ScoreId equals users.UserId
                        select new {
                            players.PlayerId, 
                            players.PlayerName,
                            score.PlayerScore,
                            users.Address,
                            users.Email
                        };
            players_datagrid.DataSource = query.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            gc.deletePlayerFromDatabase(Convert.ToInt32(delete_text.Text));
            loadPlayersFromDB();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            gc.updatePlayerInDatabase(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text),
                textBox4.Text, textBox5.Text);
            loadPlayersFromDB();
        }
    }
}
