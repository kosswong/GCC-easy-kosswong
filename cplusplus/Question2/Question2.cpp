#include <bits/stdc++.h>

using namespace std;

int findMaxProfit(int n, vector<int> price) {
    int profit[n][n+1]; 
    for (int i = 0; i < n; profit[i][0] = 0, i++){}
    for (int j = 0; j <= n; profit[0][j] = 0, j++){}
    for (int i = 1; i < n; i++) { 
        int prevDiff = INT_MIN;
        for (int j = 1; j < n; prevDiff = max(prevDiff, profit[i-1][j-1]-price[j-1]), profit[i][j] = max(profit[i][j-1], price[j]+prevDiff), j++) {} 
    } 
    return profit[n-1][n-1]; 
}

vector<int> splitStringToInt(const string& str, char delim) {
    vector<int> strings;
    size_t start;
    size_t end = 0;
    while ((start = str.find_first_not_of(delim, end)) != string::npos) {
        end = str.find(delim, start);
        strings.push_back(stoi(str.substr(start, end - start)));
    }
    return strings;
}

void printVector(vector<int> vec) {
    for (vector<int>::const_iterator i = vec.begin(); i != vec.end(); ++i)
        cout << *i << ' ';
    cout << endl;
}

int main() {
    string firstLine;
    getline(cin, firstLine);
    vector<int> firstLineVec = splitStringToInt(firstLine, ' ');
    int numOfPredictedTimes = firstLineVec[0];
    vector<int> predictedSharePrices(firstLineVec.begin()+1, firstLineVec.end());
    int result = findMaxProfit(numOfPredictedTimes, predictedSharePrices);
    cout << result << "\n";
    return 0;
}