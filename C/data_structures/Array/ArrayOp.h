#include<stdio.h>
#include<stdlib.h>

struct Array{
    int *ptr;
    int capacity;
    int used;
};

void printArray(int *arr, int size){
    printf("[");
    for(int i =0;i<size-1;i++){
        printf(" %d,", arr[i]);
    }
    printf(" %d ]\n",arr[size-1]);
}

struct Array* createArray()//returns pointer of created array structure
{
    struct Array *arr;

    arr = (struct Array*)malloc(sizeof(struct Array));

    printf("Enter the capacity for array\n ");
    scanf("%d", &arr->capacity);
    // printf("%d", arr->capacity);
    printf("........Creating a Dynamic array.........\n");
    arr->ptr = (int*)malloc(sizeof(int)*arr->capacity);
   
    if(arr->ptr == NULL){
        printf("Dynamic Array memory cannot be allocated\n");
        return NULL;
    }

    printf("Enter the no of elements you want to insert:\n ");
    scanf("%d", &arr->used);
    // printf("%d",arr->used);
    if(arr->capacity < arr->used){
        printf("Cannot contain this much elements!");
        return NULL;
    }

    printf("Enter %d Array elements\n",arr->used);
    for(int i =0;i<arr->used;i++){
        scanf("%d", arr->ptr+i);
    }
    // printf("The entered array is: \n");
    // printArray(arr->ptr,arr->used);
    return arr;
}

void swap(int* a, int* b)
{
    int temp;
    temp = *b;
    *b = *a;
    *a = temp;
}

int min(struct Array *arr){
    int min = INT_MAX;
    for(int i =0; i<arr->used;i++){
       // printf("%d\nin for loop", i);
        if(min>arr->ptr[i]){
            //printf("%d value min\n",arr->ptr[i]);
            min = arr->ptr[i];
        }
    }
    return min;
}

int max(struct Array *arr){
    int max = INT_MIN;
    for(int i =0; i<arr->used;i++){
       // printf("%d\nin for loop", i);
        if(max<arr->ptr[i]){
            //printf("%d value min\n",arr->ptr[i]);
            max = arr->ptr[i];
        }
    }
    return max;
}