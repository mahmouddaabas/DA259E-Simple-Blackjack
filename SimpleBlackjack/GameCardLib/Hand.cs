using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace GameCardLib
{
    public class Hand
    {
        public List<Card> cards { set; get; }
        public int numberOfcards { set; get; }
        public int score { set; get; }
        public string result { set; get; }

        public string name { set; get; }

        public Hand(int numcards, string name)
        {
            numberOfcards = numcards; //cards in hand
            cards = new List<Card>(); //list to hold cards
            this.name = name;
            Card emptycard = new Card();

            for (int i = 0; i < numberOfcards; i++)
            {
                cards.Add(emptycard);
            }
        }

        public void addCard(Deck currentdeck, int numberOfCardsInHand)
        {
            bool added = false;
            int pickedcard = 0;
            if(currentdeck.cards.Count <= 2)
            {
                currentdeck.createDeck();
            }
            pickedcard = Utility.NumberBetween(2, currentdeck.cards.Count - 1); 
            Card currentcard = currentdeck.cards.ElementAt(pickedcard);
            Card tobereplaced = new Card();

            while (!added)
            {
                foreach (Card temp in cards)
                {
                    if (temp.suit == "")
                        tobereplaced = temp;
                }
                if(tobereplaced != null)
                {
                    cards.Remove(tobereplaced);
                    cards.Add(currentcard);
                    added = true;
                    currentdeck.cards.Remove(currentcard);
                }
            }
        }

        public void dealCards(Deck currentdeck, int numcards)
        {
            numcards = cards.Count;
            for (int i = 0; i < numcards; i++)
            {
                addCard(currentdeck, numcards);
            }
        }

        public void evaluateHand()
        {
            score = 0;
            foreach(Card temp in cards)
            {
                if (temp.value < 10)
                    score = score + temp.value;
                else
                    score = score + 10;
            }

            foreach(Card temp in cards)
            {
                if (temp.value == 1 && score + 10 <= 21)
                    score = score + 10;
            }

            if(score > 21)
            {
                result = "Bust!";
            }
            else
            {
                result = Convert.ToString(score);
            }
        }
    }
}
