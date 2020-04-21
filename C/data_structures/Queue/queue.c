#include"queueOp.h"

int main(){
    int loop =1,op;
    bool val;
    struct queue *q;
    q = createQueue();
    if(q == NULL){
        printf("Error!");
        return 1;
    }
   while(loop){
       printf("\nEnter the following:\n0 => exit;\n1 => check isFull\n2 => check isEmpty\n3 => Enqueue\n4 => Dequeue\n5 => Display Queue\n");
        scanf("%d",&loop);
        switch (loop)
        {
        case 0:
            printf("Exiting ...\n");
            break;
        
        case 1:
            val = isFull(q);
            printf("isFull() = %s", val ? "true" : "false");
            break;
        
        case 2:
            val = isEmpty(q);
            printf("isEmpty() = %s", val ? "true" : "false");
            break;

        case 3:
            op = enqueue(q);
            if(op == 0){
                printf("Successfuly enqueued\n");
            }
            printQueue(q);
            break;

        case 4:
            op = dequeue(q);
            if(op != -1){
                if(q->type == 1)
                printf("Popped %c successfully\n",op);
                if(q->type == 0)
                printf("Popped %d successfully\n",op);
            }
            printQueue(q);
            break;
        
        case 5:
            printQueue(q);
            break;

        default:
            break;
        }
   }
    return 0;
}