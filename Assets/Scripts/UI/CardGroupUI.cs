using System.Collections.Generic;
using UnityEngine;


namespace CardGame
{
    public class CardGroupUI : MonoBehaviour
    {
        public List<Transform> UITransformCardPoints;

        private List<int> showCards = new();

        public List<int> ShowCards
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
                CardUI card = UITransformCardPoints[i].GetComponentInChildren<CardUI>();

                if (i < showCards.Count)
                {
                    if (card == null)
                    {
                        var preferb = Resources.Load<GameObject>("Card");
                        var instance = GameObject.Instantiate(preferb, UITransformCardPoints[i]);
                        card = instance.GetComponent<CardUI>();
                    }

                    card.ShowCardId = showCards[i];
                    card.gameObject.SetActive(true);
                }
                else
                {
                    if (card != null)
                    {
                        card.gameObject.SetActive(false);
                    }
                }
            }
        }
    }
}
