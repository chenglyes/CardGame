namespace CardGame
{
    public class CardGame : Singleton<CardGame>
    {
        private Fight currentFight = new();

        public Fight CurrentFight { get => currentFight; }
    }

}
