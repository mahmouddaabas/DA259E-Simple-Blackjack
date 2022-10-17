using Microsoft.VisualBasic.Devices;
using SimpleBlackjack;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace SimpleBlackjack.MoveToClassLibrary
{
    public class GameController
    {
        //Variable to recieve the MainForm and store into.
        public MainForm form { get; set; }
        public Deck currentdeck { get; set; }
        public Hand playerHand { get; set; }
        public Hand dealerHand { get; set; }
        public int numcards { get; set; }


        public GameController(MainForm form)
        {
            //Set the MainForm recieved in the constructor to the local variable.;
            this.form = form;
        }

        public void deal()
        {
            numcards = 2; //Deal 2 cards initially
            currentdeck = new Deck();
            playerHand = new Hand(numcards);
            dealerHand = new Hand(numcards);

            playerHand = new Hand(numcards);
            dealerHand = new Hand(numcards);

            playerHand.dealCards(currentdeck, numcards);
            form.showCardsPlayer(playerHand);
            playerHand.evaluateHand();
            form.getBottomTxt().Text = playerHand.result + Environment.NewLine;
        }

        public void hit()
        {
            playerHand.addCard(currentdeck, 1);
            form.showCardsPlayer(playerHand);
            playerHand.evaluateHand();
            form.getBottomTxt().Text = playerHand.result + Environment.NewLine;
            if(playerHand.score >= 21)
            {
                endGame(playerHand, dealerHand);
            }
        }

        public void stand()
        {
            endGame(playerHand, dealerHand);
            form.getHitButton().Enabled = false;
        }

        public void endGame(Hand playerHand, Hand dealerHand)
        {

            if(playerHand.score == 21)
            {
                form.getBottomTxt().Text = "Blackjack! You win!";
            }
            else
            {
                dealerHand.dealCards(currentdeck, numcards);
                dealerHand.evaluateHand();
                form.showCardsDealer(dealerHand);
                while (dealerHand.score <= 17) //dealer sticks on 17 or higher
                {
                    dealerHand.addCard(currentdeck, 1);
                    dealerHand.evaluateHand();
                    form.showCardsDealer(dealerHand);
                }
                if(playerHand.score > dealerHand.score && playerHand.score < 21)
                {
                    form.getBottomTxt().Text = "You win with: " + playerHand.score;
                }
                else if(dealerHand.score == 21)
                {
                    form.getBottomTxt().Text = "Dealer blackjack, you lose!";
                }
                else if(dealerHand.score > playerHand.score)
                {
                    form.getBottomTxt().Text = "Dealer won with: " + dealerHand.score;
                }
                else if(dealerHand.score == playerHand.score)
                {
                    form.getBottomTxt().Text = "Draw!";
                }
            }
        }
    }
}