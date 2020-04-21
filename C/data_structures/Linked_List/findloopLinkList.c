#include"linkListOp.h"

int main(){
    struct node *head,*p, *r,*temp;
    head = createNode(0);
    r = head;
    // printf("is this working?1111");
    // temp = head->next-;
    // printf("is this working?2222");
    for(int i =1; i<5; i++){        //creation of link list 0=>1=>2=>3=>4
        p = createNode(i);
        r->next = p;
        r = p;
    }
    //displayLinkList(head);
    // printf("is this working?3333");
    r->next = head->next->next;           //creation of loop  
    // printf("is this working?4444");            
    //displayLinkList(head);
    int res;
   // printf("is this working?");
    res = checkLoop(head);      //fastest method of finding loop : Floyd Cycle finding algorithm with fast node and slow node
    if(res == 1){
        printf("yes! loop exists");
    }
    else if(res == 0){
        printf("No loop exists!");
    }
    return 0;
}
