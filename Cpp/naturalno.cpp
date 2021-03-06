#include<iostream>

using namespace std;



int main(){
    int numerator = 2;
    int denominator = 6;
    int N = 0;
    float sum = 1 + (float) numerator/denominator;
    int p = 5;
    int q = 12;
    
    cout << "Enter a positive integer N = " << endl;
    cin >> N;
  
    

    if(N==0){
        cout << "0" <<endl;
        return 0;
    }
    else if(N == 1){
        cout << "1" <<endl;
        return 1;
    }
    else if(N == 2){
        cout << sum << endl;
        return 1;
    }
    else
    {
        for(int i = 2; i<N; i++){
    
        //cout<< numerator<< '*'<< p <<'/'<<denominator<<"*"<<q<<endl;
        numerator = numerator * p;
        p = p+3;
        denominator = denominator * q;
        q = q+6;
        //cout<< "sum = "<< sum <<'+'<< numerator<<"/"<<denominator<<endl;
        
        
        sum = sum + (float)numerator/denominator;
        }
    }
    
    
    cout << sum << endl;
}
