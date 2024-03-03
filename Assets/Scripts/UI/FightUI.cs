using System.Collections.Generic;
using UnityEngine;


namespace CardGame
{
    public class FightUI : MonoBehaviour
    {
        public HeadUI MyHeadUI;
        public HeadUI YourHeadUI;

        public CardGroupUI PublicCardsUI;
        public CardGroupUI MyHandCardsUI;
        public CardGroupUI YourHandCardsUI;


        private void Start()
        {
            MyHeadUI.NameText = "Joker";
            YourHeadUI.NameText = "Computer";


            CardDeck<int> deck = new CardDeck<int>();
            for (int i = 0; i < 52; ++i)
            {
                deck.AddCardRandPos(i);
            }

            List<int> cards = new();
            for (int i = 0; i < 2; ++i)
            {
                cards.Add(deck.DrawCard());
            }
            MyHandCardsUI.ShowCards = cards;

            cards = new();
            for (int i = 0; i < 2; ++i)
            {
                cards.Add(deck.DrawCard());
            }
            YourHandCardsUI.ShowCards = cards;

            cards = new();
            for (int i = 0; i < 5; ++i)
            {
                cards.Add(deck.DrawCard());
            }
            PublicCardsUI.ShowCards = cards;

        }

        
    }
}
