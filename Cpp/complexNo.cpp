#include<iostream>

using namespace std;

class complexNo
{
public:
    int real,imaginary;
    complexNo(int real = 0,int imaginary = 0);
    complexNo operator+(complexNo &c);
    friend ostream & operator<<(ostream &output, complexNo &c);
};



int main(){
    complexNo A(7,8);
    complexNo B(3,-2);
    complexNo C;
    cout << "The sum of A+B = " << endl;
    C = A + B;
    cout << C <<endl ;
    return 0;
}

complexNo :: complexNo(int real , int imaginary ){
    this->real = real;
    this->imaginary = imaginary;
}
complexNo complexNo :: operator+(complexNo &c){
    complexNo res ;
    res.real = this->real + c.real;
    res.imaginary = this->imaginary + c.imaginary;
    return res;
}

ostream & operator<<(ostream &output, complexNo &c){
    output <<c.real<<" + "<<c.imaginary<<"i";
    return output;
}