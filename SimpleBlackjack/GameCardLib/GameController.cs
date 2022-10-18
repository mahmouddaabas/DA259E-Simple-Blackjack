﻿using Utilities;

namespace GameCardLib
{
    public class GameController
    {
        //Variable to recieve the MainForm and store into.
        //public MainForm form { get; set; }
        public Deck currentdeck { get; set; }
        //public Hand playerHand { get; set; }
        public Hand dealerHand { get; set; }
        public int numcards { get; set; }
        public List<Hand> playerHands { get; set; }
        public int currentPlayer { get; set; }

        private bool handsCreated;
        public int winnerScore { get; set; }
        public int winnerIndex { get; set; }
        public int amountOfPlayers { get; set; }

        public GameController()
        {
            //Set the MainForm recieved in the constructor to the local variable.;
            //this.form = form;
            playerHands = new List<Hand>();
            currentPlayer = 0;

            ConsoleLogger clogger = new ConsoleLogger();
            FileLogger flogger = new FileLogger();

            Logger.writeMessage += clogger.LogToConsole;
            Logger.writeMessage += flogger.LogToFile;
        }

        public void createHands()
        {
            if(handsCreated == false)
            {
                for (int i = 0; i < amountOfPlayers; i++)
                {
                    Hand playerHand = new Hand(numcards);
                    playerHands.Add(playerHand);
                }
                dealerHand = new Hand(numcards);
                handsCreated = true;
            }
        }

        public void deal()
        {
            numcards = 2; //Deal 2 cards initially
            currentdeck = new Deck();
            createHands(); //Only creates hands 1 time

            playerHands[currentPlayer].dealCards(currentdeck, numcards);
            //form.showCardsPlayer(playerHands[currentPlayer]);
            playerHands[currentPlayer].evaluateHand();
            //form.getBottomTxt().Text = playerHands[currentPlayer].result + Environment.NewLine;
            Logger.LogMessage("Player: " + currentPlayer + " was dealt two cards with the value " + playerHands[currentPlayer].sco);
        }

        public void hit()
        {
            playerHands[currentPlayer].addCard(currentdeck, 1);
            //form.showCardsPlayer(playerHands[currentPlayer]);
            playerHands[currentPlayer].evaluateHand();
            //form.getBottomTxt().Text = playerHands[currentPlayer].result + Environment.NewLine;
            if(playerHands[currentPlayer].score >= 21 && currentPlayer == playerHands.Count)
            {
                //endGame(playerHands, dealerHand);
            }
            Logger.LogMessage("Player: " + currentPlayer + " decides to hit. Their score is now: " + playerHands[currentPlayer].score);
        }

        public void stand()
        {
            Logger.LogMessage("Player: " + currentPlayer + " stands.");
            currentPlayer++;
            if (currentPlayer == playerHands.Count)
            {
                //endGame(playerHands, dealerHand);
                //form.getHitButton().Enabled = false;
            }
            else if(currentPlayer < playerHands.Count)
            {
                //form.hideAndResetPlayerCards();
                //form.getPlayerLbl().Text = "Player " + currentPlayer + ":";
                //form.getBottomTxt().Text = "Player " + currentPlayer + " turn.";
            }
            //form.getHitButton().Enabled = false;
        }

        public int endGame(List<Hand> playerHands, Hand dealerHand)
        {

            for (int i = 0; i < playerHands.Count; i++)
            {
                if (playerHands[i].score > winnerScore)
                {
                    winnerScore = playerHands[i].score;
                    winnerIndex = i;
                }
            }

            if (playerHands[winnerIndex].score == 21)
            {
                //form.getBottomTxt().Text = "Blackjack! Player " + winnerIndex +  " win!";
                Logger.LogMessage("Blackjack! Player " + winnerIndex + " win!");
            }
            else
            {
                //MessageBox.Show(Convert.ToString(playerHands[winnerIndex].score));
                dealerHand.dealCards(currentdeck, numcards);
                dealerHand.evaluateHand();
                //form.showCardsDealer(dealerHand);
                while (dealerHand.score <= 17) //dealer sticks on 17 or higher
                {
                    dealerHand.addCard(currentdeck, 1);
                    dealerHand.evaluateHand();
                    //form.showCardsDealer(dealerHand);
                }
                if (winnerScore > dealerHand.score && winnerScore < 21)
                {
                    //form.getBottomTxt().Text = "Player: " + winnerIndex + " wins with: " + winnerScore;
                    Logger.LogMessage("Player: " + winnerIndex + " wins with: " + winnerScore);
                }
                else if (dealerHand.score == 21)
                {
                    //form.getBottomTxt().Text = "Dealer blackjack, you lose!";
                    Logger.LogMessage("Dealer blackjack, you lose!");
                    return -2;
                }
                else if (dealerHand.score > winnerScore && dealerHand.score < 21)
                {
                    //form.getBottomTxt().Text = "Dealer won with: " + dealerHand.score;
                    Logger.LogMessage("Dealer won with: " + dealerHand.score);
                    return -1;
                }
                else if (dealerHand.score > 21)
                {
                    //form.getBottomTxt().Text = "Dealer bust, Player: " + winnerIndex  +" wins!";
                    Logger.LogMessage("Dealer bust, Player: " + winnerIndex + " wins!");
                }
                else if (dealerHand.score == winnerScore)
                {
                    //form.getBottomTxt().Text = "Draw!";
                    Logger.LogMessage("Draw!");
                }
            }
            return winnerIndex;
        }
    }
}