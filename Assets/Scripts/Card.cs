namespace CardGame
{
    public class Card
    {
        public int Id { get; set; }

        public bool ShowFace { get; set; }

        public Card(int id, bool showFace = true)
        {
            Id = id;
            ShowFace = showFace;
        }
    }
}
