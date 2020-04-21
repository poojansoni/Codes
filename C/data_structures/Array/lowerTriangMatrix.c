#include<stdlib.h>
#include<stdio.h>
#include"matrixOp.h"
#include"ArrayOp.h"

int* createRowMajorArr(int * matrix, int size, int elements);

void printLowerMatrixArray(int* array, int size, int elements);

int setVal(int* array, int i, int j, int val);

int getVal(int *mt, int i, int j); 

//row major
int main(){
    int n = 4;
    int matrix[4][4] =  {{1,0,0,0},{2,6,0,0},{7,5,2,0},{1,9,8,7}};
    printf("Entered matrix is: (less efficient one!)\n");
    printMatrix((int*)matrix,n);
    int ele = n*(n+1)/2;
    int *p = createRowMajorArr((int*)matrix,n,ele);
    if(p == NULL){
        printf("Error while creating the array\n");
        return 1;
    }
    printf("\nThe optimized array is:\n");
    printArray(p,ele);
   // printLowerMatrixArray(p,n,ele);
    int i,j,val;
    int choice = 1,f;
    while(choice){
        printf("\nEnter:\n0 => exit;\n1 => set value;\n2 => get value\n");
        scanf("%d",&choice);
       // printf("%d", choice);
        switch (choice)
        {
        case 0:
            break;
        
         case 1:
            printf("\nEnter position in the matrix i,j and the value you want to insert:\n");
            scanf("%d%d%d",&i,&j,&val);
            printf("Value of i: %d and j: %d and n: %d\n\n",i,j,n);
            if(i < n && j<n)
            {
                f = setVal(p,i,j,val);
                if(f == 1){
                    printf("Cannot insert the value\nIs not a lower triangular element.\n");
                    break;
                }
                printf("The altered matrix is:\n");
                //printArray(p,size);
                printLowerMatrixArray(p,n,ele);
                }
            else
            {
                printf("Cannot access out-of-bound indexes!\n");
            }
            
            break;
        
        case 2:
           printf("\nEnter position in the matrix i,j for the value you want:\n");
            scanf("%d%d",&i,&j);
            if(i < n && j<n)
            {
                val = getVal(p,i,j);
                printf("The value at matrix[%d][%d] is: %d\n",i,j,val);
             }
            else
            {
                printf("Cannot access out-of-bound indexes!\n");
            }
            break;

        default:
            break;
        }
    }

    return 0;
}

int *createRowMajorArr(int* mt, int size,int ele){
    int* p = (int*)malloc(sizeof(int)*ele);
    int k = 0;
    for(int i = 0; i< size; i++){
        for(int j = 0; j<=i;j++){
            p[k] = *((mt+i*size)+j);
            k++;
        }
    }
    return p;
}

void printLowerMatrixArray(int* arr, int n, int ele){
    int i,j;
    printf("\n[\n");
    for(i =0; i< n; i++){
        printf("    [ ");
        for (j = 0; j < n-1; j++)
        {
            if(j<=i){
               // printf("Inside i not equal j\n");
                printf("%d, ", arr[i*(i+1)/2 + j]);
                
            }
            else{
                // printf("Inside i equal j\n");
                printf("0, ");
            }
        }
        if(i < j){
                printf("0 ");
            }
        else{
            printf("%d ", arr[i*(i+1)/2 + j]);
            }
        printf("]\n");
    }
    printf("]\n");
}

int setVal(int *arr, int i, int j, int val){
    if(j<=i ){
        arr[i*(i+1)/2 + j ] = val;
        return 0;
    }
    return 1;
}

int getVal(int *arr, int i, int j){
    if(j<=i){
        return arr[i*(i+1)/2 + j ];
    }
    return 0;
}