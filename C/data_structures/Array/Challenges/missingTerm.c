#include<stdio.h>
#include<stdlib.h>
#include"ArrayOp.h"

// struct Array{
//     int *ptr;
//     int capacity;
//     int used;
// };

// void printArray(int*, int);

void findMissing(struct Array);


int main(){
    struct Array Arr; 
    printf("Enter size of array to be created: ");
    scanf("%d",&Arr.capacity);
   // printf("%d",Arr.capacity);
    printf("........Creating a Dynamic array.........\n");
    Arr.ptr = (int*)malloc(sizeof(int)*Arr.capacity);
    if(Arr.ptr == NULL){
        printf("Dynamic Array memory cannot be allocated\n");
        return 1;
    }

    //Memory allocated
    printf("Enter how many numbers you want to add?\n");
    scanf("%d",&Arr.used);
    if(Arr.capacity<Arr.used){
        printf("Cannot contain this much elements!");
        return 1;
    }

    printf("Enter %d Array elements\n",Arr.used);
    for(int i =0;i<Arr.used;i++){
        scanf("%d", Arr.ptr+i);
    }
    printf("The entered array is: \n");
    printArray(Arr.ptr,Arr.used);
    findMissing(Arr);
    // miss = findMissing(Arr);

    // printArray(miss.ptr,miss.used);
return 0;
}


// void printArray(int *arr, int size){
//     printf("[");
//     for(int i =0;i<size-1;i++){
//         printf(" %d,", arr[i]);
//     }
//     printf(" %d ]\n",arr[size-1]);
// }

//finds increasing missing elements!!
void findMissing(struct Array arr){
    
    struct Array ret;
    ret.capacity = arr.ptr[arr.used-1] - arr.ptr[0];
    ret.used = 0;
    ret.ptr = (int*)malloc(sizeof(int)*arr.capacity);
    for(int i = arr.ptr[0],j=0; i<=arr.ptr[arr.used-1]; i++){
        if (i != arr.ptr[j])
        {
            //printf("inside if for %d\n",i);
            ret.ptr[ret.used] = i;
            //printf("%d is used\n",ret.used);
            ret.used++;
        }
        else{
            //printf("inside else for %d\n",i);
            j++;
        }
    }
    printf("NO. of misssing elements were %d\n",ret.used);
    printArray(ret.ptr, ret.used);
    //return ret;
}
