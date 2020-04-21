#include<stdio.h>
#include<stdlib.h>
struct Array{
    int *ptr;
    int capacity;
    int used;
};
void printArray(int*, int);

void swap( int*,int*);

struct Array enterChoice(struct Array);

void linearSearchT(struct Array, int key); //Using Transposition

struct Array insertEle(struct Array);
int main(){
    struct Array Arr;
    int choice,ele,index;
    printf("Enter size of array to be created: ");
    scanf("%d",&Arr.capacity);
   // printf("%d",Arr.capacity);
    printf("........Creating a Dynamic array.........\n");
    int *new;
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
    Arr = enterChoice(Arr);
    printf("Check...............\n");
    printArray(Arr.ptr,Arr.used);
return 0;
}

struct Array enterChoice(struct Array arr){
    int choice =1,key;
    while(choice){
        printf("Enter 0-2 for the following\n0 = Exit;\n1 = Insert element;\n2 = Search using transposition;\n");
        scanf("%d", &choice);
        switch (choice)
        {
        case 0:
            printf("Exiting...");
            break;
        case 1:
            arr = insertEle(arr);
            break;
        case 2:
            printf("Enter element to be searched\n");
            scanf("%d", &key);
            linearSearchT(arr,key);
            break;
        default:
            break;
        }
    }
    return arr;
}

    
void printArray(int *arr, int size){
    printf("[");
    for(int i =0;i<size-1;i++){
        printf(" %d,", arr[i]);
    }
    printf(" %d ]\n",arr[size-1]);
}

struct Array insertEle(struct Array arr){
    if(arr.capacity<=arr.used){
        printf("Cannot insert any element. No space!");
        exit(1);
    }
    int choice, ele;
    printf("\nInsert at:\n1)START\n2)END\n3)Enter INDEX\n");
    scanf("%d",&choice);
    printf("Enter the element to be inserted\n");
    scanf("%d",&ele);
    struct Array new;
    new.used = arr.used + 1;
    new.capacity = arr.capacity;
    new.ptr = (int*)malloc(sizeof(int)*(new.used));
    switch (choice)
    {
    case 1:
        /* code */
        new.ptr[0] = ele;
        for(int i =1;i<new.used;i++){
            new.ptr[i] = arr.ptr[i-1];
        }
        printf("New array is: \n");
        printArray(new.ptr,new.used);
        return new;
        break;

    case 2:
        /* code */
    
        new.ptr[new.used - 1] = ele;
        for(int i =0;i<new.used - 1;i++){
            new.ptr[i] = arr.ptr[i];
        }
        printf("New array is: \n");
        printArray(new.ptr,new.used);
        return new;
        break;

    case 3:
        /* code */
        printf("Enter the index: \n");
        int index;
        scanf("%d", &index);
        for(int i =0;i<index;i++){
            new.ptr[i] = arr.ptr[i];
        }

        new.ptr[index] = ele;

        for(int i = index+1;i<new.used;i++){
            new.ptr[i] = arr.ptr[i-1];
        }
        printf("New array is: \n");
        printArray(new.ptr,new.used);
        return new;
        break;

    default:
        printf("Invalid option");
        return arr;
        break;
    }
}

void linearSearchT(struct Array Arr, int key){
    int i;
    int flag = 0;
    for(i = 0 ; i < Arr.used; i++){
        if( Arr.ptr[i] == key){
            if(i != 0 )
                swap(Arr.ptr+i,Arr.ptr+i-1);
            flag = 1;
            break;
        } 
    }

    if(flag)
        printf("Found element at position :%d \n",i);
    else
        printf("Element not found\n");

    printArray(Arr.ptr,Arr.used);
    
}

void swap(int* a, int* b)
{
    int temp;
    temp = *b;
    *b = *a;
    *a = temp;
}
