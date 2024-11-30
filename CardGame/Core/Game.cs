
public class Game
{
    private readonly ICardRepository _cardRepository;
    private List<Card> _playerHand;
    private List<Card> _computerHand;

    public Game(ICardRepository cardRepository)
    {
        _cardRepository = cardRepository;
        _playerHand = new List<Card>();
        _computerHand = new List<Card>();
    }

    public void StartGame()
    {
        _cardRepository.ShuffleDeck();
        _playerHand.Add(_cardRepository.DealCard());
        _computerHand.Add(_cardRepository.DealCard());

        Console.WriteLine("Game Started!");
    }

    public void ShowHands()
    {
        Console.WriteLine("Player Hand:");
        foreach (var card in _playerHand)
        {
            Console.WriteLine($"{card.Rank} of {card.Suit}");
        }

        Console.WriteLine("Computer Hand:");
        foreach (var card in _computerHand)
        {
            Console.WriteLine($"{card.Rank} of {card.Suit}");
        }
    }

    public List<Card> GetPlayerHand() => _playerHand;
    public List<Card> GetComputerHand() => _computerHand;
}
