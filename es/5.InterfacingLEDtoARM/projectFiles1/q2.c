#include <LPC17xx.h>
#include <stdio.h>
void delay()
{
    int j;
    for(j=0;j<10000;j++);
}
int main()
{
    unsigned long LED = 0x00000000;
    unsigned long Switch = 0x1<<23;
    SystemInit();
    SystemCoreClockUpdate();
    // LED ARRAY CONNECTED TO PORT A -> P0.4 - P0.11 
    // function select for pins
    LPC_PINCON->PINSEL0 = 0;
    LPC_PINCON->PINSEL2 = 0;
    // set input or output for the pins 
    LPC_GPIO0->FIODIR = 0xFFFFFFFF; // led all port output
    LPC_GPIO1->FIODIR = 0x0; // input for switch
    int up =0; //upcounter = 0, downcounter = 1;
    while(1)
    {
        // set led 
        LPC_GPIO0->FIOPIN = LED<<4;
        LPC_GPIO1->FIOMASK1 = ~Switch;
        up = LPC_GPIO1->FIOPIN>>23; 
        //call delay
        delay();
        // up or down count
        if(up)
        {
            LED += 1;
            if(LED == 0x10)
            {
                LED = 0;
            }
        }
        else
        {
            LED -= 1;
            if(LED == -1)
            {
                LED = 0xF;
            }
        }
        //poll events
        LPC_GPIO0->
            
    }
    return 0;
}
