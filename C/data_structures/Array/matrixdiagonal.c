#include<stdio.h>
#include<stdlib.h>
#include"matrixOp.h"
#include"ArrayOp.h"

int checkDiagonalmatrix(int *mt, int size); //checks is matrix is diagonal

int *createEffArr(int *mt, int n);  //creates array parsed from matrix

void printMatrixArray(int *mt,int n);   //prints the optimized array in matrix form

int setVal(int *mt, int i, int j, int val); //set value in matrix

int getVal(int *mt, int i, int j);  //gives the value

int main(){
    int matrix[4][4] =  {{1,0,0,0},{0,6,0,0},{0,0,2,0},{0,0,0,7}};
    int i,j,val;
    int size = 4;
    printf("\nOriginal Matrix: (less efficient one!)\n");
    printMatrix((int *)matrix,size);
    int check = checkDiagonalmatrix((int*)matrix,size);
    if(check == 1){
        printf("Its not a diagonal matrix\n");
        return 1;
    }
    int *p = createEffArr((int *)matrix, size);
    if(p == NULL){
        printf("Error in creating array\n");
        return 1;
    }
    printf("\nAfter creating efficient array:\n");
    printArray(p,size);
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
            if(i < size && j<size)
            {
                f = setVal(p,i,j,val);
                if(f == 1){
                    printf("Cannot insert the value\nIs not a diagonal element.\n");
                    break;
                }
                printf("The altered matrix is:\n");
                //printArray(p,size);
                printMatrixArray(p,size);
             }
            else
            {
                printf("Cannot access out-of-bound indexes!\n");
            }
            
            break;
        
        case 2:
           printf("\nEnter position in the matrix i,j for the value you want:\n");
            scanf("%d%d",&i,&j);
            if(i < size && j<size)
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

int checkDiagonalmatrix(int *mt, int size){
    int flag = 0;
    for(int i =0; i< size; i++){
        for (int j = 0; j < size; j++)
        {
            if(*((mt+i*size) + j) != 0 && j != i ){
                flag = 1;
                return flag;
            }
        }
    }
    return flag;
}

int *createEffArr(int *mt, int n){
    int *p = (int*)malloc(sizeof(int)*n);
   
    if(p == NULL){
        printf("Dynamic Array memory cannot be allocated\n");
        return NULL;
    }
    for(int i = 0, j = 0; i<n,j<n; i++,j++){
        p[i] = *((mt+i*n) + j);
    }
    return p;
}

int setVal(int *mt, int i, int j, int val){
    if( i == j){
        mt[i] = val;
        return 0;
    }
    return 1;
}

void printMatrixArray(int* mt, int n){
    int i,j;
    printf("\n[\n");
    for(i =0; i< n; i++){
        printf("    [ ");
        for (j = 0; j < n-1; j++)
        {
            if(i != j){
               // printf("Inside i not equal j\n");
                printf("0, ");
            }
            else{
                // printf("Inside i equal j\n");
            printf("%d, ", mt[i]);
            }
        }
        if(i != j){
                printf("0 ");
            }
        else{
            printf("%d ", mt[i]);
            }
        printf("]\n");
    }
    printf("]\n");
}

int getVal(int *mt, int i, int j){
    if(i == j){
        return mt[i];
    }
    return 0;
}