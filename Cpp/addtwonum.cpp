/*2. Add Two Numbers
Medium

9582

2414

Add to List

Share
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

 

Example 1:


Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.
Example 2:

Input: l1 = [0], l2 = [0]
Output: [0]
Example 3:

Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]
 

Constraints:

The number of nodes in each linked list is in the range [1, 100].
0 <= Node.val <= 9
It is guaranteed that the list represents a number that does not have leading zeros.*/

#include<iostream>
#include<vector>

using namespace std;

struct ListNode {
    int val;
    ListNode *next;
    ListNode() : val(0), next(nullptr) {}
    ListNode(int x) : val(x), next(nullptr) {}
    ListNode(int x, ListNode *next) : val(x), next(next) {}
};

/* utility funtion */
void printList(ListNode *l1){
    while(l1){
        cout << l1->val << "->";
        l1 = l1->next;
    }
}

class Solution {
public:
    ListNode* addTwoNumbers(ListNode* l1, ListNode* l2) {
        int carry = 0, flag=0;
        ListNode *res,*follower,*temp=nullptr;
      
        for(; l1 != nullptr && l2 != nullptr; l1 = l1->next, l2 = l2->next){
           // cout<< l1->val + l2->val<<endl;
           int sum = l1->val + l2->val + carry;

           if(sum>9){
               // carry
                carry = sum / 10;
                sum %= 10;
           }
           else
               // no carry
                carry = 0;
           
           temp = new ListNode(sum);

           if(flag==0){
               flag=1;
               res = follower = temp;
           }
           else{
                follower->next = temp;
                follower = temp;
           }
            
        }
        
        while(l1 != nullptr){
            int sum = l1->val + carry;
            if(sum>9){
                carry = sum / 10;
                sum %= 10;
            }
            else
                carry = 0;
            
            temp = new ListNode(sum);

            follower->next = temp;
            follower = temp;
            
            l1 = l1->next;
        }
        
        while(l2 != nullptr){
            int sum = l2->val + carry;
            if(sum>9){
                carry = sum / 10;
                sum %= 10;
            }
            else
                carry = 0;
            
            temp = new ListNode(sum);

            follower->next = temp;
            follower = temp;
            
            l2 = l2->next;
        }
        
        if(carry){
            temp = new ListNode(carry);
            follower->next = temp;
        }
        
        return res;
    }
};

int main(){
    vector<int> a = {9, 9, 9, 9, 9};
    vector<int> b = {9, 9, 9};

    ListNode *l1, *l2, *temp;
    temp = nullptr;
    for(int i=0; i<a.size(); i++)
        temp = new ListNode(a[i], temp);
    l1 = temp;

    temp = nullptr;
    for(int i=0; i<b.size(); i++)
        temp = new ListNode(b[i], temp);
    l2 = temp;

    printList(l1);
    cout << endl;
    printList(l2);
    cout << endl;
    cout << endl;

    ListNode *result = Solution().addTwoNumbers(l1, l2);
    printList(result);

    return 0;
}