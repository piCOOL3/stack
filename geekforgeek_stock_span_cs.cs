using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace geekforgeek_stock_span_cs
{
    class solution
    {
        static void calculateSpan (int[] prices , int  prices_count )
        {
            // calculate the maximum stock span for each of the prices and return the stock span 

            Stack<int> stock_span = new Stack<int>(prices_count);
            // define a stack collection lifo , space used : n 

            stock_span.Push(-1);
            // initialize the stack collection with -1 

            // iterate all the prices one by one  and calculate the span of each price in O(n)
            for (int i = 0; i < prices_count ; i++)
            {
                // iterate the stack collection to remove the top element if the stack is not empty and top stock price is less than the current stock price
                while (stock_span.Peek() != -1 && prices[stock_span.Peek()] < prices[i])
                {
                    stock_span.Pop();
                    // remove the stock price from the stack 
                }
                Console.Write("the stock span for price : " + prices[i] + "  is : " + (i - stock_span.Peek()));
                Console.WriteLine();
                // print the stock price and the span of the stock price

                stock_span.Push(i);
                // store the current price in the stack
            }
            
        }
        static void Main(string[] args)
        {
            int[] prices = { 10, 4, 5, 90, 120, 80 };
            // collection containing the  prices 

            int prices_count = prices.Length;
           // calculate the no of prices in the collection 

            
            calculateSpan(prices, prices_count );
            // call the function to calculate the span of the prices and print the span in the console.

            Console.ReadLine();
        }
    }
}
