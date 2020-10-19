# You may change this function parameters
def findMaxProfit(numOfPredictedTimes, predictedSharePrices):
    # Participants code will be here
    maxi = 0   
    n = numOfPredictedTimes
    for k in range(1, n):
        profit = [[0 for i in range(n + 1)]  
                     for j in range(k + 1)]  
      
        # Fill the table in bottom-up fashion  
        for i in range(1, k + 1):  
            prevDiff = float('-inf') 
            for j in range(1, n):  
                prevDiff = max(prevDiff, 
                               profit[i - 1][j - 1] - 
                               predictedSharePrices[j - 1])  
                profit[i][j] = max(profit[i][j - 1],  
                                   predictedSharePrices[j] + prevDiff)  
  
        if profit[k][n - 1] >= maxi:
            maxi = profit[k][n - 1]
        
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