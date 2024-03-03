namespace CardGame
{
    public class Fight
    {
        private CardDeck<Card> deck = new();

        public CardDeck<Card> Deck { get => deck; set => deck = value; }

        public void Init()
        {
            for (int i = 0; i < 52; ++i)
            {
                Deck.AddCardRandPos(new Card(i, false));
            }
        }
    }
}
