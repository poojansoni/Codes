#include<stdio.h>
#include<stdlib.h>
int count = 0;
struct node{
    struct node *next;
    int value;
};

struct node* createNode(int value){
    struct node* p = (struct node*)malloc(sizeof(struct node));
    if(p==NULL){
        return NULL;
    }
    p->next = NULL;
    p->value = value;
    return p;
}

struct node* createLinkList(int *array, int size){
    struct node* p, *h;
    p = (struct node*)malloc(sizeof(struct node)*size);
    h = p;
    if(p==NULL){
        return NULL;
    }
    for(int i =0; i<size-1;i++){
        (p+i)->value = array[i];
        (p+i)->next = p+i+1;
       // printf("%d value stored in pointer\n",(p+i)->value);
    }
    (p+size-1)->next = NULL;
    (p+size-1)->value = array[size-1];
    //printf("%d value stored in pointer\n",(p+size-1)->value);
    return h;
}

void displayLinkList(struct node* head){
    struct node* p;
    p= head;
    printf("The link list is:\n");
    while(p->next != NULL){
        printf("%d=>",p->value);
        p = p->next;
    }
    printf("%d\n",p->value);
}

int reverseDisplay(struct node* h){
    struct node* p = h;
    if(p->next == NULL){
        printf("%d=>",p->value);
        return 0;
    }
    count++;
    //printf("%d,count\n",count);
    reverseDisplay(p->next);
    count--;
    //printf("%d, count \n",count);
    if(count == 0){
        printf("%d",h->value);
    }
    else{
        printf("%d=>",h->value);
    }
    
    return 0;
}

struct node* search(struct node* head, int value){
    int count = 0,flag =1;
    struct node* p, *q,*temp;
    p = head;
    temp = NULL;
    q = NULL;
    while(flag && p!=NULL){
        count++;
        temp = p->next;
       //printf("%d,count \n",count);
        if(p->value == value && count!=1){
            q->next = head;
            p->next = head->next;
            head->next = temp;
            head = p;
            flag = 0;
            break;
        }
        else if(p->value == value && count==1){
            printf("Element found at position %d :\n",count--);
            flag = 0;
            return p;
        }
        q = p;
        p = p->next;
    }
    if(flag){
        printf("Element not found!\n");
        return NULL;
    }
    printf("Element found at position %d :\n",count--);
    return p;
}

int insertVal(struct node* h, int val, int x){
    //printf("heyyyyy");
    struct node* p, *q;
    q = createNode(val);
    //printf("%d q value\n",q->value);
    p = h;
    while(p!=NULL && p->value != x){
        //printf("inside while loop\n");
        p = p->next;
    }
    
    if(p == NULL){
        printf("No element %d to insert after.\n",x);
        return 0;
    }
    
    q->next = p->next;
    p->next = q;
    return 1;
   
}

int deleteNode(struct node** headkaPointer, int val){
    struct node* p, *q = NULL;
    p = *headkaPointer ;

    //if there is only one element left
    if(p->next == NULL && p->value == val){
        return -1;
    }

    //for the first element to be deleted
    if(p->value == val && p->next != NULL){
        *headkaPointer = p->next;
        p->next = NULL;
        return 1;
    }

    //for finding value in between
    while(p!=NULL && p->value != val){
        q= p;
        p = p->next;
    }
   
   //if no value found
    if(p == NULL){
        printf("No element %d to delete from the link list.\n",val);
        return 0;
    }
    q->next = p->next;
    p->next = NULL;
    return 1;
}

void reverseLinkList(struct node** headkaPointer){
    struct node *r,*q,*p;
    r = NULL;
    q= NULL;
    p = *headkaPointer;
    while(p!=NULL){
        r = q;
        q = p;
        p = p->next;
        q->next = r;
    }

    *headkaPointer = q;
    
}

//Floyd Cycle finding algorithm with fast node and slow node
int checkLoop(struct node* head){
    struct node* p, *q;
    //int count = 0;
    p = head;
    q = p;
    while(p->next != NULL && p->next->next !=NULL){
        //printf("%d, count\n",count);
       // count++;
        p = p->next->next;
        q = q->next;
        if(p == q){
            return 1;
        }
    }
    return 0;
}

struct node* createCircularLinkList(int *array, int size){
    struct node* p, *h;
    p = (struct node*)malloc(sizeof(struct node)*size);
    h = p;
    if(p==NULL){
        return NULL;
    }
    for(int i =0; i<size-1;i++){
        (p+i)->value = array[i];
        (p+i)->next = p+i+1;
       // printf("%d value stored in pointer\n",(p+i)->value);
    }
    (p+size-1)->next = h;
    (p+size-1)->value = array[size-1];
    //printf("%d value stored in pointer\n",(p+size-1)->value);
    return h;
}