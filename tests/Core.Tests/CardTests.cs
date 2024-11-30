
using Xunit;

public class CardTests
{
    [Fact]
    public void Card_ShouldHaveRankAndSuit()
    {
        var card = new Card("A", "Hearts");
        Assert.Equal("A", card.Rank);
        Assert.Equal("Hearts", card.Suit);
    }
}
