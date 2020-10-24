#include<bits/stdc++.h>
using namespace std;
string find_min_days(int profit[], int price[], int n, int d)
{
	//Participants will add code here
        string stringToReturn = "";
        for(int k = 0; k < d; k++){
            int iOfMinj = 0;
            int minj = 100001;
            for(int i = 0; i < n; i++){
                for(int j = i+1; j < n; j++){
                    if(price[j]-price[i] == profit[k]){
                        if(j <= minj){
                            iOfMinj = i;
                            minj = j;
                        }
                    }
                }
            }
            if(minj != 100001){
                if(k > 0)
                    stringToReturn = stringToReturn + ",";
                stringToReturn = stringToReturn + to_string(iOfMinj+1) + " " + to_string(minj+1);
            }else{
                if(k > 0) 
                    stringToReturn = stringToReturn + ",";
                stringToReturn = stringToReturn + "-1";
            }
        }
        return stringToReturn;
}

int main ()
{
	int n,d,i;
	string answer="";
	cin>>n>>d;
	int price[n];
	int profit[d];
	for (i=0;i<n;i++)
		cin>>price[i];
	for (i=0;i<d;i++)
	    cin>>profit[i];
    answer = find_min_days(profit,price,n,d);

    // Do not remove below line
	cout<<answer<<endl;
    // Do not print anything after this line

	return 0;
}