using Potter_Kata;

namespace CartTests;

public class CartTests
{
    Cart classUnderTest;

    [OneTimeSetUp]
    public void Setup()
    {
        classUnderTest = new Cart();
    }

    [Test]
    public void No_books_returns_0()
    {
        Assert.Fail();
    }
}