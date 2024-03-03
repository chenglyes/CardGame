using System.Collections.Generic;
using UnityEngine;


namespace CardGame
{
    public class ResourceManager : Singleton<ResourceManager>
    {
        private Dictionary<int, Sprite> LoadedSprite = new();

        public Sprite LoadSprite(int id)
        {
            if (LoadedSprite.TryGetValue(id, out Sprite sprite))
                return sprite;

            var texture = Resources.Load<Texture2D>("8BitDeck");

            int row = id / 13;
            int col = id % 13;

            Rect rect = new(col * 142, row * 190, 142, 190);
            Vector2 pivot = new(0.5f, 0.5f);
            sprite = Sprite.Create(texture, rect, pivot);

            return sprite;
        }

    }
}
