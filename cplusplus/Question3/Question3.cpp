#include<bits/stdc++.h>
using namespace std;
string find_min_days(int profit[], int price[])
{
	//Participants code will be here
    return "";

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
    answer = find_min_days(profit,price);

    // Do not remove below line
	cout<<answer<<endl;
    // Do not print anything after this line

	return 0;
}