using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace CardGame
{
    public class CardUI : MonoBehaviour
    {
        [Header("Info")]
        [SerializeField] private int showCardId = 0;
        [SerializeField] private bool showFace = true;

        [Header("Highlight")]
        public GameObject UIObjectHighlight;
        //public Image UIImageHighLight;

        [Header("Face")]
        public GameObject UIObjectFace;
        public List<Image> UIImageFaceLayers;

        [Header("Back")]
        public GameObject UIObjectBack;
        public List<Image> UIImageBackLayers;

        //private bool showHighlight = false;

        public int ShowCardId
        {
            get => showCardId;
            set
            {
                showCardId = value;
                Sprite sprite = CardGame.Instance.GetResourceManager().LoadSprite(showCardId);
                UIImageFaceLayers[1].sprite = sprite;
            }
        }

        public bool ShowFace
        {
            get => showFace;
            set
            {
                showFace = value;
                UpdateShowFace();
            }
        }

        private void UpdateShowFace()
        {
            UIObjectFace.SetActive(showFace);
            UIObjectBack.SetActive(!showFace);
        }

        private void Start()
        {
            UpdateShowFace();
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
