# You may change this function parameters
def findMaxProfit(numOfPredictedTimes, predictedSharePrices):
    # Participants code will be here
    maxi = 0  
    n = numOfPredictedTimes
    for k in range(2, n):
        profit = [[0 for i in range(k + 1)] 
                     for j in range(n)] 
          
        # Profit is zero for the first 
        # day and for zero transactions 
        for i in range(1, n): 
              
            for j in range(1, k + 1): 
                max_so_far = 0
                  
                for l in range(i): 
                    max_so_far = max(max_so_far, predictedSharePrices[i] -
                                predictedSharePrices[l] + profit[l][j - 1]) 
                                  
                profit[i][j] = max(profit[i - 1][j], max_so_far) 
          
        if profit[n - 1][k] >= maxi:
            maxi = profit[n - 1][k]
        
    return maxi

def main():
    line = input().split()
    numOfPredictedTimes = int(line[0])
    predictedSharePrices = list(map(int, line[1:]))

    answer = findMaxProfit(numOfPredictedTimes, predictedSharePrices)
    # Do not remove below line
    print(answer)
    # Do not print anything after this line

if __name__ == '__main__':
    main()