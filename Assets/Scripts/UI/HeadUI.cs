using UnityEngine;
using UnityEngine.UI;


namespace CardGame
{
    public class HeadUI : MonoBehaviour
    {
        public Image UIImageHead;
        public Text UITextName;

        private Sprite headSprite;
        private string nameText;

        public Sprite HeadSprite
        {
            get => headSprite;
            set
            {
                headSprite = value;
                UIImageHead.sprite = value;
            }
        }

        public string NameText
        {
            get => nameText;
            set
            {
                nameText = value;
                UITextName.text = value;
            }
        }
    }
}
