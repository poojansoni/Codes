#include<stdio.h>
int memoisation[50] = {[0 ... 49] = -1 };
int fibo(int);
int main(){
    int n;

    // initialization of basic results
    memoisation[0] = 0;
    memoisation[1] = 1;

    printf("Enter the no:th element for fibonacci:\n");
    scanf("%d", &n);

    int result =  fibo(n);
    printf("\n%dth term is: %d \n", n, result);

    printf("\nMemoization table: \n");
    for(int i=0; i<50; i++)
        printf("%d ",memoisation[i]);
    printf("\n");

    return 0;
}
int fibo(int n){
    if(n<=1){
        return n ;   
    }
    else{
        if (memoisation[n-2]==-1)
        {
            memoisation[n-2] = fibo(n-2);
        }
        if (memoisation[n-1]==-1)
        {
            memoisation[n-1] = fibo(n-1);
        }
        memoisation[n] = memoisation[n-2] + memoisation[n-1] ;
        return memoisation[n] ;  
    }
}