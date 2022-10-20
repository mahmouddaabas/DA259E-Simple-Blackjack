
using System.Reflection;
using System.Windows.Forms;
using GameCardLib;

namespace SimpleBlackjack
{
    public partial class MainForm : Form
    {

        private GameController gc;
        private int amountOfPlayers;
        public MainForm()
        {
            InitializeComponent();

            //Create a GameController object and send the MainForm object to it.
            gc = new GameController();
            hideAllCards();
            loadPlayersFromDB();
        }

        public void loadPlayersFromDB()
        {
            players_datagrid.DataSource = gc.getAllPlayers().ToList();
        }
        private void startgame_btn_Click(object sender, EventArgs e)
        {
            startgame_btn.Enabled = false;
            amountOfPlayers = Convert.ToInt32(amountofplayers_txt.Text);
            gc.amountOfPlayers = amountOfPlayers;
        }

        private void deal_btn_Click(object sender, EventArgs e)
        {
            gc.deal();
            showCardsPlayer(gc.playerHands[gc.currentPlayer]);
            bottom_txtbox.Text = gc.playerHands[gc.currentPlayer].result + Environment.NewLine;
            player_lbl.Text = gc.playerHands[gc.currentPlayer].name + " :";
            //deal_btn.Enabled = false;
        }

        private void hit_btn_Click(object sender, EventArgs e)
        {
            gc.hit();
            showCardsPlayer(gc.playerHands[gc.currentPlayer]);
            if (gc.playerHands[gc.currentPlayer].score >= 21 && gc.currentPlayer == gc.playerHands.Count)
            {
                int winner = gc.endGame(gc.playerHands, gc.dealerHand);
                showCardsDealer(gc.dealerHand);
                checkWinner(winner);
            }
            bottom_txtbox.Text = gc.playerHands[gc.currentPlayer].result + Environment.NewLine;
        }

        private void stand_btn_Click(object sender, EventArgs e)
        {
            gc.stand();
            if(gc.playerHands.Count == gc.currentPlayer)
            {
                int winner = gc.endGame(gc.playerHands, gc.dealerHand);
                showCardsDealer(gc.dealerHand);
                checkWinner(winner);
                //bottom_txtbox.Text = "Player: " + winner + " has won!";
                hit_btn.Enabled = false;
            }
            else if(gc.currentPlayer < gc.playerHands.Count)
            {
                hideAndResetPlayerCards();
                player_lbl.Text = gc.playerHands[gc.currentPlayer].name + " :";
                bottom_txtbox.Text = gc.playerHands[gc.currentPlayer].name+ ": turn.";
            }
        }

        public void checkWinner(int winner)
        {
            if (winner.Equals(-1))
            {
                bottom_txtbox.Text = "Dealer has won! He got " + gc.dealerHand.score;
            }
            else if (winner.Equals(-2))
            {
                bottom_txtbox.Text = "Dealer blackjack, you lose!";
            }
            else
            {
                bottom_txtbox.Text = gc.playerHands[gc.currentPlayer] + " has won!";
            }
        }

        public Button getStartBtn()
        {
            return this.startgame_btn;
        }

        public RichTextBox getBottomTxt()
        {
            return this.bottom_txtbox;
        }

        public Button getHitButton()
        {
            return this.hit_btn;
        }

        public Label getPlayerLbl()
        {
            return this.player_lbl;
        }

        #region showCardsFunctions
        public void showCardsPlayer(Hand playerHand)
        {
            int count = 0;
            string currentCardPicture = "";

            if (gc.playerHands[gc.currentPlayer].cards != null && gc.playerHands[gc.currentPlayer] != null)
                foreach (Card currentcard in gc.playerHands[gc.currentPlayer].cards)
                {
                    if (currentcard != null && currentcard.suit != "")
                    {
                        if (currentcard.value < 10)
                            currentCardPicture = "0" + currentcard.value.ToString() + "_" + currentcard.suit;
                        if (currentcard.value == 10)
                            currentCardPicture = "0" + currentcard.value.ToString() + "_" + currentcard.suit;
                        if (currentcard.value == 11)
                            currentCardPicture = "0" + currentcard.value.ToString() + "_" + currentcard.suit;
                        if (currentcard.value == 12)
                            currentCardPicture = "0" + currentcard.value.ToString() + "_" + currentcard.suit;
                        if (currentcard.value >= 13)
                            currentCardPicture = "0" + currentcard.value.ToString() + "_" + currentcard.suit;
                    }
                    else
                        currentCardPicture = "space";
                    if (count == 0)
                    {
                        card1_box.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        card1_box.Image = myImage;
                        card1_box.SizeMode =
                       PictureBoxSizeMode.StretchImage;
                    }
                    if (count == 1)
                    {
                        card2_box.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        card2_box.Image = myImage;
                    }
                    if (count == 2)
                    {
                        card3_box.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        card3_box.Image = myImage;
                    }
                    if (count == 3)
                    {
                        card4_box.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        card4_box.Image = myImage;
                    }
                    if (count == 4)
                    {
                        card5_box.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        card5_box.Image = myImage;
                    }
                    if (count == 5)
                    {
                        card6_box.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        card6_box.Image = myImage;
                    }
                    if (count == 6)
                    {
                        card7_box.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        card7_box.Image = myImage;
                    }
                    if (count == 7)
                    {
                        card1_box.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        card1_box.Image = myImage;
                    }
                    if (count == 8)
                    {
                        card2_box.Visible = true;
                        System.Resources.ResourceManager rm =
                        SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        card2_box.Image = myImage;
                    }
                    if (count == 9)
                    {
                        card3_box.Visible = true;
                        System.Resources.ResourceManager rm =
                        SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage = (Bitmap)rm.GetObject(currentCardPicture);
                        card3_box.Image = myImage;

                    }
                    if (count == 10)
                    {
                        card4_box.Visible = true;
                        System.Resources.ResourceManager rm =
                        SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        card4_box.Image = myImage;
                    }
                    if (count == 11)
                    {
                        card5_box.Visible = true;
                        System.Resources.ResourceManager rm =
                        SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        card5_box.Image = myImage;
                    }
                    count++;
                }
        }

        public void showCardsDealer(Hand dealerHand)
        {
            int count = 0;
            string currentCardPicture = "";

            if (gc.playerHands[gc.currentPlayer-1].cards != null && gc.playerHands[gc.currentPlayer-1] != null)
                foreach (Card currentcard in gc.dealerHand.cards)
                {
                    if (currentcard != null && currentcard.suit != "")
                    {
                        if (currentcard.value < 10)
                            currentCardPicture = "0" + currentcard.value.ToString() + "_" + currentcard.suit;
                        if (currentcard.value == 10)
                            currentCardPicture = "0" + currentcard.value.ToString() + "_" + currentcard.suit;
                        if (currentcard.value == 11)
                            currentCardPicture = "0" + currentcard.value.ToString() + "_" + currentcard.suit;
                        if (currentcard.value == 12)
                            currentCardPicture = "0" + currentcard.value.ToString() + "_" + currentcard.suit;
                        if (currentcard.value >= 13)
                            currentCardPicture = "0" + currentcard.value.ToString() + "_" + currentcard.suit;
                    }
                    else
                        currentCardPicture = "space";
                    if (count == 0)
                    {
                        dealer_box1.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box1.Image = myImage;
                        dealer_box1.SizeMode =
                       PictureBoxSizeMode.StretchImage;
                    }
                    if (count == 1)
                    {
                        dealer_box2.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box2.Image = myImage;
                    }
                    if (count == 2)
                    {
                        dealer_box3.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box3.Image = myImage;
                    }
                    if (count == 3)
                    {
                        dealer_box4.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box4.Image = myImage;
                    }
                    if (count == 4)
                    {
                        dealer_box5.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box5.Image = myImage;
                    }
                    if (count == 5)
                    {
                        dealer_box1.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box1.Image = myImage;
                    }
                    if (count == 6)
                    {
                        dealer_box2.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box2.Image = myImage;
                    }
                    if (count == 7)
                    {
                        dealer_box3.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box3.Image = myImage;
                    }
                    if (count == 8)
                    {
                        dealer_box4.Visible = true;
                        System.Resources.ResourceManager rm =
                        SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box4.Image = myImage;
                    }
                    if (count == 9)
                    {
                        dealer_box5.Visible = true;
                        System.Resources.ResourceManager rm =
                        SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage = (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box5.Image = myImage;

                    }
                    if (count == 10)
                    {
                        dealer_box1.Visible = true;
                        System.Resources.ResourceManager rm =
                        SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box1.Image = myImage;
                    }
                    if (count == 11)
                    {
                        dealer_box2.Visible = true;
                        System.Resources.ResourceManager rm =
                        SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box2.Image = myImage;
                    }
                    count++;
                }
        }
        #endregion

        public void hideAllCards()
        {
            card1_box.Visible = false;
            card2_box.Visible = false;
            card3_box.Visible = false;
            card4_box.Visible = false;
            card5_box.Visible = false;
            card6_box.Visible = false;
            card7_box.Visible = false;
            dealer_box1.Visible = false;
            dealer_box2.Visible = false;
            dealer_box3.Visible = false;
            dealer_box4.Visible = false;
            dealer_box5.Visible = false;
        }

        public void hideAndResetPlayerCards()
        {
            card1_box.Visible = false;
            card2_box.Visible = false;
            card3_box.Visible = false;
            card4_box.Visible = false;
            card5_box.Visible = false;
            card6_box.Visible = false;
            card7_box.Visible = false;
            card1_box.Image = null;
            card2_box.Image = null;
            card3_box.Image = null;
            card4_box.Image = null;
            card5_box.Image = null;
            card6_box.Image = null;
            card7_box.Image = null;
        }
    }
}