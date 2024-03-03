using System.Collections.Generic;
using UnityEngine;


namespace CardGame
{
    public class CardGroupUI : MonoBehaviour
    {
        public List<Transform> UITransformCardPoints;

        private List<Card> showCards = new();

        public List<Card> ShowCards
        {
            get => showCards;
            set
            {
                showCards = value;
                UpdateUI();
            }
        }

        private void UpdateUI()
        {
            for (int i = 0; i < UITransformCardPoints.Count; ++i)
            {
                CardUI cardUI = UITransformCardPoints[i].GetComponentInChildren<CardUI>();

                if (i < showCards.Count)
                {
                    if (cardUI == null)
                    {
                        var preferb = Resources.Load<GameObject>("Card");
                        var instance = GameObject.Instantiate(preferb, UITransformCardPoints[i]);
                        cardUI = instance.GetComponent<CardUI>();
                    }

                    cardUI.ShowCard = showCards[i];
                    cardUI.gameObject.SetActive(true);
                }
                else if (cardUI != null)
                {
                    cardUI.gameObject.SetActive(false);
                }
            }
        }
    }
}
