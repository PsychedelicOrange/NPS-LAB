#include <LPC17xx.h>
#include <stdio.h>
void delay()
{
    int i,j;
    for(j=0;j<100000;j++)
    {
        for(i =0;i<100;i++);
    }
}
int main()
{
    unsigned long LED = 0x00000000;
    int up =0; //upcounter = 0, downcounter = 1;
    SystemInit();
    SystemCoreClockUpdate();
    // LED ARRAY CONNECTED TO PORT A -> P0.4 - P0.11 
    // function select for pins
    LPC_PINCON->PINSEL0 = 0;
    // set input or output for the pins 
    LPC_GPIO0->FIODIR = 0xFFFFFFFF; // led all port output

    while(1)
    {
        // set led 
        LPC_GPIO0->FIOPIN = LED<<4;
        
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
        up = !(LPC_GPIO2->FIOPIN & 1<<12); 
            
    }
    return 0;
}
