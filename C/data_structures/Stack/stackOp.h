#include<stdio.h>
#include<stdlib.h>
#include<stdbool.h>

struct stack{
    int size;
    int type; //character = 1 or integer = 0
    int *stack;
    int top;
};

//creates stack with size defined by user using integer array initialization, with top = -1
struct stack *createStack(){
    struct stack *stk;
    stk = (struct stack *)malloc(sizeof(struct stack));
    if(stk == NULL){
        printf("cannot create stack\n");
        return NULL;
    }
    printf("Enter the type of stack you want to initialize:\n0 => only integer\n1 => integer + charcters\n");
    scanf("%d",&stk->type);
    printf("Enter the size of stack you want to initialize:\n");
    scanf("%d",&stk->size);
    stk->stack = (int*)malloc(sizeof(int)*stk->size);
    if(stk->stack == NULL){
        printf("cannot create stack array\n");
        return NULL;
    }
    stk->top = -1;
    return stk;
}


bool isEmpty(struct stack* stk){
    if(stk->top == -1){
        return true;
    }
    return false;
}

bool isFull(struct stack* stk){
    if(stk->top == (stk->size-1)){
        return true;
    }
    return false;
}

int push(struct stack* stk){
    bool check = isFull(stk);
    int ele;
    int op;
    if(check == true){
        printf("Cannot push element further, stack is full!\n");
        return 1;
    }
    printf("Enter element to be inserted:\n");
    if(stk->type == 0){
        scanf("%d",&ele);
    }
    if(stk->type == 1){
        scanf("%s", &ele);
    }
    stk->stack[stk->top+1] = ele;
    stk->top = stk->top+1;
    return 0;
}

int pop(struct stack* stk){
    bool check = isEmpty(stk);
    if(check == true){
        printf("Cannot pop element further, stack is Empty\n");
        return -1;
    }
    int ele;
    ele = stk->stack[stk->top];
    stk->top = stk->top -1;
    return ele;
}

int printStack(struct stack* stk){
    if(isEmpty(stk)){
        printf("Empty stack cannot be dislplayed!\n");
    }
    if(stk->type == 0){
    for(int i = stk->top; i>=0; i--)
        {
            printf("[ ");
            printf("%d", stk->stack[i]);
            printf(" ]\n");
        }
    }
    else if(stk->type == 1){
    for(int i = stk->top; i>=0; i--)
        {
            printf("[ ");
            printf("%c", stk->stack[i]);
            printf(" ]\n");
        }
    }
    
}