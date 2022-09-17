#include <LPC17xx.h>
#include <stdio.h>
void delay()
{
    int j;
    for(j=0;j<100;j++);
        //{for(i=0;i<10000;i++);}
}
int main()
{
    unsigned long LED = 0x00000010;
    SystemInit();
    SystemCoreClockUpdate();
    // LED ARRAY CONNECTED TO PORT A -> P0.4 - P0.11 
    // function select for pins
    LPC_PINCON->PINSEL0 = 0;
    // set input or output for the pins 
    LPC_GPIO0->FIODIR = 0x10; // 4th bit to output rest are input 
    while(1)
    {
        // set led 
        LPC_GPIO0->FIOSET = LED;
        //call delay
        delay();
        // clear led
        LPC_GPIO0->FIOCLR = LED;
        //call delay
        delay();
    }
    return 0;
}
