'''
 https://www.geeksforgeeks.org/the-stock-span-problem/


'''

def calculateSpan(prices, prices_count, stock_span) :
    ### the function will calculate the span of each price and store it in stock_span list 
    '''
    
    algorithm : 

    1. iterate the list  i ---> 0 to n-1
    2. for every price traversed [i] --->   iteratively check if price[i] > price[stack[-1]] ---> pop the top 
                                            calculate the span and push into the stack
    '''
    
    stack = [-1]
    ### implement a stack data structure using a list . stack is set to -1 .
    ### stack will store all the indices of the prices

    for i in range(len(prices)):
        while (stack[-1] != -1 and prices[stack[-1]] < prices[i]):
            stack.pop()

        #print("the span of the stock price:",prices[i],"is :",i - stack[-1])
        stock_span.insert( i , i - stack[-1])
        stack.append(i)

def printArray(stock_span , prices, prices_count):
    # print the stock span for each price 

    for i in range(prices_count) :
        print("the span of the stock price:",prices[i],"is :" ,stock_span[i])


# Driver program to test above function     
prices = [100, 80, 60, 70, 60, 75, 85]
prices_count = len(prices)
stock_span = [None]  * prices_count

# Fill the span values in list S[] 
calculateSpan(prices, prices_count, stock_span) 

# Print the calculated span values 
printArray(stock_span ,prices, prices_count) 