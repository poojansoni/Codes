#include<stdio.h>
#include<stdlib.h>

int main(){

    int x;

    scanf("%d", &x);

    int A[x];

    for(int i=0; i<x+2; i++){
        scanf("%d", &A[i]);
    }
    
    for(int i=0 ; i<x+5; i++){
        printf("%d ",A[i]);
    }
    return 0;
}