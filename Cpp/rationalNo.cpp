#include<iostream>

using namespace std;
int MAX = 1000;
class rationalNo
{
public:
    int numerator,denominator;
    rationalNo(int numerator = 0,int denominator = 1);
    rationalNo operator+(rationalNo &c);
    friend ostream & operator<<(ostream &output, rationalNo &c);
};



int main(){
    rationalNo A(7,0);
    rationalNo B(3,-2);
    rationalNo C;
    if(A.numerator != MAX && B.numerator != MAX){
        cout << "The sum of A+B = " << endl;
        C = A + B;
        cout << C <<endl ;
    }
    else{
        cout << "Cannot perform operation because no. was infinty" << endl;
    }
    return 0;
}

rationalNo :: rationalNo(int nm , int dm ){
    if(dm == 0){
        this->numerator = MAX;
    }
    this->numerator = nm;
    this->denominator = dm;
}
rationalNo rationalNo :: operator+(rationalNo &c){
    rationalNo res ;
    res.numerator = this->numerator*c.denominator + c.numerator*this->denominator;
    res.denominator = this->denominator*c.denominator;
    //to simplify we need common factors 
    return res;
}

ostream & operator<<(ostream &output, rationalNo &c){
    output <<c.numerator<<"/"<<c.denominator;
    return output;
}