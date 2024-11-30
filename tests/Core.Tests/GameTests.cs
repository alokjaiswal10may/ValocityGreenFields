
using Moq;
using Xunit;

public class GameTests
{
    [Fact]
    public void Game_ShouldStartWithShuffledDeck()
    {
        var cardRepositoryMock = new Mock<ICardRepository>();
        cardRepositoryMock.Setup(r => r.ShuffleDeck()).Verifiable();
        cardRepositoryMock.Setup(r => r.DealCard()).Returns(new Card("A", "Spades"));

        var game = new Game(cardRepositoryMock.Object);
        game.StartGame();

        cardRepositoryMock.Verify(r => r.ShuffleDeck(), Times.Once);
    }

    [Fact]
    public void Game_ShouldDealCardsToPlayers()
    {
        var cardRepositoryMock = new Mock<ICardRepository>();
        cardRepositoryMock.Setup(r => r.DealCard()).Returns(new Card("A", "Spades"));

        var game = new Game(cardRepositoryMock.Object);
        game.StartGame();

        var playerHand = game.GetPlayerHand();
        var computerHand = game.GetComputerHand();

        Assert.Single(playerHand);
        Assert.Single(computerHand);
    }
}
