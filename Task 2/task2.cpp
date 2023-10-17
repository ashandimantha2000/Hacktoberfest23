#include <bits/stdc++.h>
using namespace std;

bool is_prime(int num){
    for(int i = 2;i<=sqrt(num);i++){
        if(num%i==0) return false;
    }
    return true;
}

signed main()
{
    int i = 100;
    while(i>1){
        if(is_prime(i)) cout<<i<<" ";
        i--;
    }
    cout<<endl;
}

/*

Output:

    97 89 83 79 73 71 67 61 59 53 47 43 41 37 31 29 23 19 17 13 11 7 5 3 2 

*/
