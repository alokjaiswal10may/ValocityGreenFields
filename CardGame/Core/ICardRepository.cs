
public interface ICardRepository
{
    List<Card> GetAllCards();
    void ShuffleDeck();
    Card DealCard();
}
