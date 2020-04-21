#include<stdio.h>
#include<stdlib.h>
#include"ArrayOp.h"

int main(){
    struct Array *arr;
    int mini, maxm, size,j,count = 0;
    arr = createArray();
    if(arr == NULL){
        printf("Error occurred");
        return 1;
    }
    printf("The entered array is: \n");
    printArray(arr->ptr,arr->used);
    mini = min(arr);
    maxm = max(arr);
    //printf("%d is max\n%d is min\n",maxm,mini);
    size = maxm-mini+1;
    int res[size];  
    // initializing array elements 
    for (int i = 0; i < size ; i++){ 
        res[i] = -1; 
    }
    //filling the table with already given values:
    for(int i =0;i<arr->used;i++){
        j=arr->ptr[i] - mini;
        res[j]+=1;
    }
    printf("_____________________________\n\n");
    //printArray(res,size);
    for(int i = 0; i<size;i++){
        if(res[i] == -1){
            res[i] = i + mini;
            printf("%d ", res[i]);
            count++;
        }
    }
   printf("\n%d is the count of missing terms\n",count);
    return 0;
}