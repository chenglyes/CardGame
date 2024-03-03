using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CardGame
{
    public class CardGame
    {
        private ResourceManager resourceManager = new();

        public ResourceManager GetResourceManager() => resourceManager;


        private static CardGame instance;

        public static CardGame Instance
        {
            get
            {
                instance ??= new CardGame();
                return instance;
            }
        }




    }
}
