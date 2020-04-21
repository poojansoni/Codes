#include<stdio.h>
#include<stdlib.h>

void printMatrix(int*matrix, int size){
    printf("\n[\n");
    for(int i =0; i< size; i++){
        printf("    [ ");
        for (int j = 0; j < size-1; j++)
        {
            printf("%d, ", *((matrix+i*size) + j));
        }
        printf("%d ",*((matrix+i*size) + size-1));
        printf("]\n");
    }
    printf("]\n");
}