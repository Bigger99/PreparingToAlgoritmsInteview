namespace PreparingToAlgoritmsInteview;

// Моё решение оказалось не оптимальным, взял готовое из решений
internal class BestTimeToBuyAndSellStock_121
{
    public BestTimeToBuyAndSellStock_121()
    {
        Console.WriteLine(MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));
        Console.WriteLine(MaxProfit(new int[] { 7, 6, 4, 3, 1 }));
        Console.WriteLine(MaxProfit(new int[] { 2, 4, 1 }));
    }

    public int MaxProfit(int[] prices)
    {
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
                minPrice = prices[i];

            int profit = prices[i] - minPrice;

            if (profit > maxProfit)
                maxProfit = profit;
        }

        return maxProfit;

        //var maxProfit = 0;

        //for (var i = 0; i < prices.Length; i++)
        //{
        //    var buyValue = prices[i];

        //    for (var j = i; j < prices.Length; j++)
        //    {
        //        var sellValue = prices[j];

        //        if (maxProfit < sellValue - buyValue)
        //            maxProfit = sellValue - buyValue;
        //    }
        //}

        //return maxProfit;

        //if (prices.Length <= 0)
        //    return 0;

        //var buyIndex = 0;
        //var minValue = prices[0];

        //for (var i = 0; i < prices.Length; i++)
        //{
        //    if (prices[i] <= minValue && i != prices.Length - 1)
        //    {
        //        buyIndex = i;
        //        minValue = prices[i];
        //    }
        //}

        //var sellIndex = buyIndex;

        //for (var i = buyIndex; i < prices.Length; i++)
        //{
        //    if (prices[i] > prices[sellIndex])
        //        sellIndex = i;
        //}

        //if (sellIndex == 0 || sellIndex == buyIndex)
        //    return 0;

        //return prices[sellIndex] - prices[buyIndex];
    }
}
