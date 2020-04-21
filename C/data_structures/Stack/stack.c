#include"stackOp.h"

int main(){
    int loop =1,op;
    bool val;
    struct stack *stk;
    stk = createStack();
    if(stk == NULL){
        printf("Error!");
        return 1;
    }
   while(loop){
       printf("\nEnter the following:\n0 => exit;\n1 => check isFull\n2 => check isEmpty\n3 => push a element\n4 => pop a element\n5 => Display stack\n");
        scanf("%d",&loop);
        switch (loop)
        {
        case 0:
            printf("Exiting ...\n");
            break;
        
        case 1:
            val = isFull(stk);
            printf("isFull() = %s", val ? "true" : "false");
            break;
        
        case 2:
            val = isEmpty(stk);
            printf("isEmpty() = %s", val ? "true" : "false");
            break;

        case 3:
            op = push(stk);
            if(op == 0){
                printf("Successfuly pushed\n");
            }
            printStack(stk);
            break;

        case 4:
            op = pop(stk);
            if(op != -1){
                if(stk->type == 1)
                printf("Popped %c successfully\n",op);
                if(stk->type == 0)
                printf("Popped %d successfully\n",op);
            }
            printStack(stk);
            break;
        
        case 5:
            printStack(stk);
            break;

        default:
            break;
        }
   }
    return 0;
}