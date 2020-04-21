#include<stdio.h>
#include<stdlib.h>
#include<stdbool.h>
struct queue{
    int size;
    int front;
    int rear;
    int type;
    int *que;
};

//creates queue with size defined by user using integer array initialization
struct queue *createQueue(){
    struct queue *q;
    q = (struct queue *)malloc(sizeof(struct queue));
    if(q == NULL){
        printf("cannot create queue\n");
        return NULL;
    }
    printf("Enter the type of queue you want to initialize:\n0 => only integer\n1 => integer + charcters\n");
    scanf("%d",&q->type);
    printf("Enter the size of queue you want to initialize:\n");
    scanf("%d",&q->size);
    q->que = (int*)malloc(sizeof(int)*q->size);
    if(q->que == NULL){
        printf("cannot create que array\n");
        return NULL;
    }
    q->front = 0;
    q->rear = 0;
    return q;
}


bool isEmpty(struct queue* q){
    if(q->front == q->rear){
        return true;
    }
    return false;
}

bool isFull(struct queue* q){
    if( (q->rear-q->front) == q->size){
        return true;
    }
    return false;
}

int enqueue(struct queue* q){
    bool check = isFull(q);
    int ele;
    int op;
    if(check == true){
        printf("Cannot enqueue, queue is full!\n");
        return 1;
    }
    printf("Enter element to be inserted:\n");
    if(q->type == 0){
        scanf("%d",&ele);
    }
    if(q->type == 1){
        scanf("%s", &ele);
    }
    q->que[q->rear] = ele;
    q->rear = q->rear +1;
    return 0;
}

int dequeue(struct queue* q){
    bool check = isEmpty(q);
    if(check == true){
        printf("Cannot Dequeue, Que is Empty\n");
        return -1;
    }
    int ele;
    ele = q->que[q->front];
    q->front = q->front +1;
    return ele;
}

int printQueue(struct queue* q){
    if(isEmpty(q)){
        printf("Empty que cannot be dislplayed!\n");
        return 1;
    }
    printf("Front=> ");
    if(q->type == 0){
    for(int i = q->front; i<q->rear; i++)
        {
            printf("[ ");
            printf("%d", q->que[i]);
            printf(" ] ");
        }
    }
    else if(q->type == 1){
    for(int i = q->front; i<q->rear; i++)
        {
            printf("[ ");
            printf("%c", q->que[i]);
            printf(" ] ");
        }
    }
    printf("<=Rear \n");
    return 0;
}