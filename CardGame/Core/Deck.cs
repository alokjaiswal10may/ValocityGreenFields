
public class Deck
{
    private List<Card> _cards;

    public Deck()
    {
        _cards = new List<Card>();
        InitializeDeck();
    }

    private void InitializeDeck()
    {
        var ranks = new[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        var suits = new[] { "Hearts", "Diamonds", "Clubs", "Spades" };

        foreach (var suit in suits)
        {
            foreach (var rank in ranks)
            {
                _cards.Add(new Card(rank, suit));
            }
        }
    }

    public void Shuffle()
    {
        var rng = new Random();
        _cards = _cards.OrderBy(c => rng.Next()).ToList();
    }

    public Card DealCard()
    {
        var card = _cards.FirstOrDefault();
        _cards.Remove(card);
        return card;
    }

    public List<Card> GetAllCards() => _cards;
}