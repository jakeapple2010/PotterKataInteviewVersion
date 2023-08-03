using System.Collections.Generic;
using System.Linq;

namespace Potter_Kata;

public class Cart
{
    public decimal CalculateCost(int[] books)
    {
        if (books == null || books.Length == 0)
        {
            return 0m;
        }

        if (books.Distinct().Count() == 1)
        {
            return books.Length * 8m;
        }

        decimal finalCost = 0m;
        int last = -1;
        var visited = new List<int>();
        var bookCounts = new Dictionary<int, int>();

        for (int i = 0; i < books.Length; i++)
        {
            var bookId = books[i];
            if (bookCounts.ContainsKey(bookId))
            {
                var val = bookCounts[bookId];
                bookCounts[bookId] = val++;
                continue;
            }
            bookCounts[bookId] = 1;
            //if (last < 0)
            //{
            //    last = books[0];
            //    visited.Add(last);
            //    finalCost = 8m;
            //    continue;
            //}

            //if (visited.Contains(bookId))
            //{
            //    finalCost+= 8m * 0.95m;
            //}
            //else
            //{
            //    finalCost += 8m;
            //    visited.Add(bookId);
            //}
        }

        for (int i = 0; i < books.Length; i++)
        {
            var bookSetCount = 0;
            var rate = 1m;

            var counter = bookCounts.Keys;
            foreach (var key in counter)
            {

                if (bookCounts[key] > 0)
                {
                    bookSetCount++;
                    bookCounts[key]--;
                }

                if (bookSetCount == 2)
                {
                    rate = 0.95m;
                }

                if (bookSetCount == 3)
                {
                    rate = 0.9m;
                }

                if (bookSetCount == 4)
                {
                    rate = 0.8m;
                }

                if (bookSetCount == 5)
                {
                    rate = .75m;
                }
            }

            finalCost += bookSetCount * 8 * rate;
        }

        return finalCost;
    }
}