using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlackjack.MoveToClassLibrary
{
    public class Deck
    {
        public List<Card> cards { set; get; }
        public Deck()
        {
            cards = new List<Card>();
            createDeck();
        }

        public void createDeck()
        {
            cards.Clear();
            int cardnum = 1;
            for (int i = 1; i < 5; i++) //4 suits
            {
                for(int j = 1; j < 14; j++) //13 cards each (52 total)
                {
                    Card currentcard = new Card();
                    currentcard.cardNumber = cardnum;
                    if (i == 1)
                        currentcard.suit = "spades";
                    if (i == 2)
                        currentcard.suit = "clubs";
                    if (i == 3)
                        currentcard.suit = "hearts";
                    if (i == 4)
                        currentcard.suit = "diamonds";
                    // assign value
                    currentcard.value = j;
                    // put in deck
                    cards.Add(currentcard);
                    // adding card to deck
                    //next card
                    cardnum++;
                }
            }
        }

        public Card findCard(int cardnum)
        {
            foreach(Card aCard in cards)
            {
                if(aCard.cardNumber == cardnum)
                {
                    return aCard;
                }
            }
            return null;
        }
    }
}
