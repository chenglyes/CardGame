using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace CardGame
{
    public class FightUI : MonoBehaviour
    {
        public HeadUI MyHeadUI;
        public HeadUI YourHeadUI;

        public CardGroupUI PublicCardsUI;
        public CardGroupUI MyHandCardsUI;
        public CardGroupUI YourHandCardsUI;

        public Transform UITransformControlBox;
        public Button UIButtonRaise;
        public Button UIButtonCall;

        public Text UITextChips;


        private void Start()
        {
            MyHeadUI.NameText = "Joker";
            YourHeadUI.NameText = "Computer";

            Fight fight = CardGame.Instance.CurrentFight;
            fight.Init();

            List<Card> cards = new();
            for (int i = 0; i < 2; ++i)
            {
                Card card = fight.Deck.DrawCard();
                card.ShowFace = true;
                cards.Add(card);
            }
            MyHandCardsUI.ShowCards = cards;

            cards = new();
            for (int i = 0; i < 2; ++i)
            {
                cards.Add(fight.Deck.DrawCard());
            }
            YourHandCardsUI.ShowCards = cards;

            cards = new();
            for (int i = 0; i < 5; ++i)
            {
                cards.Add(fight.Deck.DrawCard());
            }
            PublicCardsUI.ShowCards = cards;



        }

        
    }
}
