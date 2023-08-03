using NUnit.Framework;
using Potter_Kata;

namespace Tests
{
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
            var books = new int[] { };

            var result = classUnderTest.CalculateCost(books);

            Assert.AreEqual(0m, result);
        }

        [Test]
        public void No_Books_Null_Returns_0()
        {
            var result = classUnderTest.CalculateCost(null);

            Assert.AreEqual(0m, result);
        }

        [Test]
        public void One_Book_Retuns_8()
        {
            var books = new int[] {1};

            var result = classUnderTest.CalculateCost(books);

            Assert.AreEqual(8m, result);
        }
        
        [Test]
        public void Two_of_the_same_book_returns_16()
        {
            var books = new int[] {1, 1};

            var result = classUnderTest.CalculateCost(books);

            Assert.AreEqual(16m, result);
        }

        [Test]
        public void Two_of_the_different_books_return_15_2()
        {
            var books = new int[] { 1, 2 };

            var result = classUnderTest.CalculateCost(books);

            Assert.AreEqual(15.6m, result);
        }

        [Test]
        public void Three_of_the_different_books_returns_21_6()
        {
            var books = new int[] { 1, 2, 3 };

            var result = classUnderTest.CalculateCost(books);

            Assert.AreEqual(21.6m, result);
        }
    }
}