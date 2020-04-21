#include<stdio.h>

double r = 1;
double taylorHorner(int x, int presicion);

int main(){
    int x, pres;
    double result;
    printf("To calculate e^x, enter x and precision no: \n");
    scanf("%d %d", &x, &pres);
    result = taylorHorner(x,pres);
    printf("e^%d: %0.3f",x, result);
    return 0;
}

double taylorHorner(int x, int pres){
    if(pres > 0){
        r = 1.0 + (double)x/pres*r;
        //printf("%f",r);
        pres--;
        return taylorHorner(x,pres);
    }
    return r;
}