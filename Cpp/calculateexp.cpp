#include <cmath>
#include<iostream>
#include <cstdlib> 
using namespace std;

int main(){
    int n;
    cout << "Enter the no of data to be stored in array"<< endl;
    cin >> n ;
    if(n<1){
        cout<< "cannot calculate"<<endl;
        return 1;
    }
    double avg = 0;
    double res =0;
    int *arr = new int(n);
    cout<< "enter the data values Xi"<< endl;
    for(int i = 0; i< n; i++){
        cin>> arr[i];
        avg = avg + arr[i];
        //cout <<"avg"<< avg<< endl;
    }

    avg = (double)avg/n;
    //cout<<"avg"<<avg<<endl;

    for(int i = 0; i<n;i++){
        res = res + pow(abs((arr[i] - avg)),n);
        //cout<< "exp"<< res<< endl;
    }

    res = res/(n*(n-1));
    res = sqrt(res);
    cout << "result is = "<< res <<endl;
    return 0;
}