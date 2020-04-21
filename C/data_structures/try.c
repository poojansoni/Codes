#include<stdio.h>
#include<stdlib.h>
int main()
{
    int i;
    i=0;
    do
    {
        printf("%d %c \n",i,i);
        i++;
    }
    while(i<=255);
    printf("enter a char");
    int x;
    scanf("%c",&x);
    printf("%d, %c", x,x);
    return 0;
}