#include"linkListOp.h"
#include"ArrayOp.h"

int main(){
    struct node *head, *temp;
    struct Array *arr;
    arr = createArray();
    // printf("Created array is:\n");
    // printArray(arr->ptr,arr->used);
    head = createLinkList(arr->ptr,arr->used);
    temp = head;
    int choice= 1;
    int val,x,check;
    while(choice){
        printf("\n\nEnter the following:\n0 => exit;\n1 => Display Link List\n2 => Display reverse link list\n3 => search any element\n4 => Insert a value :\n5 => Delete any Element\n6 => reverse the link list!\n");
        scanf("%d",&choice);
        switch (choice)
        {
        case 0:
            printf("Exiting ...\n");
            break;
        
        case 1:
            displayLinkList(head);
            break;
        
        case 2:
            printf("\nReverse display of link list:\n");
            reverseDisplay(head);
            break;
        case 3:
            
            printf("\nEnter the value to be searched: \n");
            scanf("%d",&val);
            temp = search(head,val);
            if(temp == NULL){
                printf("NO element found!\n");
            }
           else{
               head = temp;
           }
            displayLinkList(head);
            
            break;

        case 4:
            printf("Enter values: x that has to be inserted after any element y: \n");
            scanf("%d%d",&val,&x);
            check = insertVal(head,val,x);
            if(check){
                printf("After inserting:\n \n");
                displayLinkList(head);
            }
            printf("\n");
            break;
        
        case 5:
            printf("Enter element x that has to be deleted: \n");
            scanf("%d",&val);
            check = deleteNode(&head,val);
            if(check>0){
                printf("After deleting:\n");
                displayLinkList(head);
            }
            else if(check == -1){
                printf("NO elements left!\nBye bye!");
                return 0;
            }

            printf("\n");
            break;

        case 6:
            reverseLinkList(&head);
            printf("\nReversed link list is:\n");
            displayLinkList(head);

        default:
            break;
        }
    }
    return 0;
}