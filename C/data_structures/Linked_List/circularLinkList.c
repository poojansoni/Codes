#include<stdio.h>
#include<stdlib.h>
#include"linkListOp.h"

int insert(struct node *head,int val,int x);
struct node* delete(struct node *head , int index);
void display(struct node* head);

int main(){
    struct node *head;
    printf("_______CIRCULAR LINK LIST CREATION_______\n");
    printf("Enter the size of link list to be created:\n");
    int size,loop =1,val,x,check;
    scanf("%d",&size);
    int arr[size];
    printf("Enter %d Elements to the link list\n",size);
    for(int i=0; i<size; i++)
        scanf("%d",&arr[i]);
    head = createCircularLinkList(arr,size);
    
    while(loop){
        printf("Enter the following:\n0 = > exit\n1 => Insert\n2 => Delete\n3 => Display\n");
        scanf("%d",&loop);
        switch(loop){
        case 0:
            printf("Exiting ...\n");
            break;

        case 1:
            printf("Enter the value and element after which you want to insert\n");
            scanf("%d%d",&val,&x);
            check = insert(head,val,x);
            if(check){
                printf("After inserting:\n \n");
                display(head);
            }
            printf("\n");
            break;
        
        case 2:
            printf("Enter the index of element that has to be deleted: \n");
            scanf("%d",&val);
            head = delete(head,val);
            if(head == NULL){
                return 1;
            }
            display(head);
            break;

        case 3:
            display(head);
            break;
        }
    }
    return 0;
}

int insert(struct node* head,int val, int x){
    struct node* p, *q;
    q = createNode(val);
    p = head;
    while(p->value != x && p->next!=head){
        //printf("inside while loop\n");
        p = p->next;
    }
    
    if(p->value == x){
        q->next = p->next;
        p->next = q;
        return 1;
    }
    else{
        printf("No element %d to insert after.\n",x);
        return 0;
    }
}

void display(struct node* head){
    struct node* p;
    p= head;
    printf("The Circular link list is:\n");
    while(p->next != head){
        printf("%d=>",p->value);
        p = p->next;
    }
    printf("%d\n",p->value);
}

struct node *delete(struct node *head, int index){
    struct node *temp = head;
    int count =0 ;
    while(temp->next != head){
            count++;
            temp = temp->next;
        }
        
    temp = head;

    if((count == 0) && index == 0){
        printf("Deleted last element!\n");
        printf("BYE BYE!..\n");
        return NULL;
    }
    if(index==0){
        //for first position
        while(temp->next != head){
            temp = temp->next;
        }
        temp->next = head->next;
        temp = temp->next;
        return temp;
    }
    else{
        if(count<index){
            printf("Cannot access out of bound indexes!\n");
            return head;
        }
        struct node *p = NULL;
        for(int i=0; i<index ; i++){
            p = temp;
            temp = temp->next;
        }
        p->next = temp->next;
        return head;
    }
}