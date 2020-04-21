#include<stdio.h>
#include<stdlib.h>

void mergesort(int* array,int left,int right);
void merge(int *array, int left, int mid,int right);
void printArray(int*, int);
int main(){
    int size, *arr;
    printf("Enter the size of array you want to create:\n");
    scanf("%d", &size);
    arr = (int *)malloc(sizeof(int)*size);
    if(arr == NULL){
        printf("cannot create the array\n");
        return 1;
    }
    printf("Enter %d elements\n",size);
    for(int i=0; i<size;i++){
        scanf("%d", arr+i);
    }
    printf("____________________________________________\n");
    printf("\nThe entered array is:\n");
    printArray(arr,size);
    printf("\nCalling Mergesort........\n");
    mergesort(arr,0,size-1);
    printf("\nAfter mergesort the array is:\n");
    printArray(arr,size);
    return 0;
}

void printArray(int *arr, int size){
    printf("[");
    for(int i =0;i<size-1;i++){
        printf(" %d,", arr[i]);
    }
    printf(" %d ]\n",arr[size-1]);
}

void mergesort(int *arr, int left, int right){
    int mid;
    if(left<right){
        mid = (left+right)/2;
        mergesort(arr,left,mid);
        mergesort(arr,mid+1,right);
        merge(arr,left,mid,right);
    }
}

void merge(int *arr, int left, int mid,int right){
    int i, j, k; 
    int size_l = mid - left + 1; 
    int size_r =  right - mid ; 
  //out of pace sort happens
    int leftArr[size_l], rightArr[size_r]; 

    for (i = 0; i < size_l; i++) 
        leftArr[i] = arr[left + i]; 

    for (j = 0; j < size_r; j++) 
        rightArr[j] = arr[mid + 1+ j]; 

    i = 0; 
    j = 0; 
    k = left;

    while (i < size_l && j < size_r) 
    { 
        if (leftArr[i] <= rightArr[j]) 
        { 
            arr[k] = leftArr[i]; 
            i++; 
        } 
        else
        { 
            arr[k] = rightArr[j]; 
            j++; 
        } 
        k++; 
    } 
    while (i < size_l) 
    { 
        arr[k] = leftArr[i]; 
        i++; 
        k++; 
    } 
    while (j < size_r) 
    { 
        arr[k] = rightArr[j]; 
        j++; 
        k++; 
    } 
}
