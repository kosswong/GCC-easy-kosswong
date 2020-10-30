#include <bits/stdc++.h>
using namespace std;
int findMaxProfit(int n, vector<int> p) {
    int max = -1; for(int i=0;i < n;i++)for(int j=i+1; j < n; j++)if(p[j]-p[i] > max)max = p[j]-p[i]; return max;
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
    int numOfPredictedDays = firstLineVec[0];
    vector<int> predictedSharePrices(firstLineVec.begin()+1, firstLineVec.end());
    int result = findMaxProfit(numOfPredictedDays, predictedSharePrices);
    cout << result << "\n";
    return 0;
}