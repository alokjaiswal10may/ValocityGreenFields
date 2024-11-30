
using Xunit;

public class DeckTests
{
    [Fact]
    public void Deck_ShouldHave52CardsInitially()
    {
        var deck = new Deck();
        var allCards = deck.GetAllCards();
        Assert.Equal(52, allCards.Count);
    }

    [Fact]
    public void Deck_ShouldShuffleCards()
    {
        var deck = new Deck();
        var initialCards = deck.GetAllCards();
        deck.Shuffle();
        var shuffledCards = deck.GetAllCards();
        Assert.NotEqual(initialCards, shuffledCards);
    }

    [Fact]
    public void Deck_ShouldDealCard()
    {
        var deck = new Deck();
        var card = deck.DealCard();
        Assert.NotNull(card);
        Assert.Equal(51, deck.GetAllCards().Count);
    }
}
