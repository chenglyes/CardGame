using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Assertions;


namespace CardGame
{

    public class CardDeck<T>
    {
        public List<T> Cards { get => mCards; }

        private List<T> mCards = new();

        public void Shuffle()
        {
            List<T> tempCards = mCards;
            mCards.Clear();

            foreach (T card in tempCards)
            {
                AddCardRandPos(card);
            }
        }

        public void AddCardTop(T card)
        {
            mCards.Insert(0, card);
        }

        public void AddCardBottom(T card)
        {
            mCards.Add(card);
        }

        public void AddCardRandPos(T card)
        {
            if (mCards.Count == 0)
            {
                mCards.Add(card);
            }
            else
            {
                int index = Random.Range(0, mCards.Count);
                mCards.Insert(index, card);
            }
        }

        public T DrawCard()
        {
            Assert.IsTrue(mCards.Count > 0);

            var card = mCards[0];
            mCards.RemoveAt(0);
            return card;
        }

        public T GetTopCard()
        {
            Assert.IsTrue(mCards.Count > 0);

            return mCards.First();
        }

        public T GetBottomCard()
        {
            Assert.IsTrue(mCards.Count > 0);

            return mCards.Last();
        }

    }

}
