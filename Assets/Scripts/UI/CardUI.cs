using System.Collections.Generic;
using System.Resources;
using UnityEngine;
using UnityEngine.UI;


namespace CardGame
{
    public class CardUI : MonoBehaviour
    {
        [Header("Highlight")]
        public GameObject UIObjectHighlight;
        //public Image UIImageHighLight;

        [Header("Face")]
        public GameObject UIObjectFace;
        public List<Image> UIImageFaceLayers;

        [Header("Back")]
        public GameObject UIObjectBack;
        public List<Image> UIImageBackLayers;

        private Card showCard = new(0);


        public Card ShowCard
        {
            get => showCard;
            set
            {
                showCard = value;
                UIImageFaceLayers[1].sprite = ResourceManager.Instance.LoadSprite(showCard.Id);
                UIImageFaceLayers[2].gameObject.SetActive(false);
                UIObjectFace.SetActive(showCard.ShowFace);
                UIObjectBack.SetActive(!showCard.ShowFace);
            }
        }

        private void OnMouseEnter()
        {
            UIObjectHighlight.SetActive(true);
        }

        private void OnMouseExit()
        {
            UIObjectHighlight.SetActive(false);
        }
    }
}
