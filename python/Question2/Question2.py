# You may change this function parameters
def findMaxProfit(numOfPredictedTimes, predictedSharePrices):  
  
    k = numOfPredictedTimes-1
    
    profit = [[0 for i in range(numOfPredictedTimes + 1)]  
                 for j in range(k + 1)]  
  
    # Fill the table in bottom-up fashion  
    for i in range(1, k + 1):  
        prevDiff = float('-inf') 
          
        for j in range(1, numOfPredictedTimes):  
            prevDiff = max(prevDiff, 
                           profit[i - 1][j - 1] - 
                           predictedSharePrices[j - 1])  
            profit[i][j] = max(profit[i][j - 1],  
                               predictedSharePrices[j] + prevDiff)  
  
    return profit[k][numOfPredictedTimes - 1]  

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