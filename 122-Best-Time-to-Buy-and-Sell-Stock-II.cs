public class Solution {
    public int MaxProfit(int[] prices) {
        var profit = 0;
        var startWindow = 0;
        for (int endWindow = 1; endWindow < prices.Length; endWindow++)
        {
            if (prices[endWindow] > prices[startWindow])
                profit += prices[endWindow] - prices[startWindow];
            startWindow = endWindow;
        }

        return profit;
    }
}