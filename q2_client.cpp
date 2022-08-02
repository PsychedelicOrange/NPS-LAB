#include <string.h>
#include <arpa/inet.h>
#include <stdlib.h>
#include <stdio.h>
#include <unistd.h>
#include <sys/socket.h>
#include <sys/types.h>
#include <netinet/in.h>
#include <fentl.h>
#include <sys/stat.h>
#include <iostream>

int main ()
{
    int s,r,recb,sntb,x;
    socklen_t len,sa;
    std::cout << "INPUT port number: ";
    std::cin >> x;
    struct sockaddr_in, server ,client;
    char buff [50];
    s = socket(AF_INET,SOCK_DGRAM,0);
    if(s == -1 )
    {
        std::cout << "\nSocket Creation Error.";
        return -1;
    }
    std::cout << "\nSocket created.";
    server.sin_family = AF_INET;
    server.sin_port = htons(x);
    server.sin_addr.s_addr = inet_addr("127.0.0.1");
    sa = sizeof( server );
    len = sizeof(s,buff,sizeof(buff),0,(struct sockaddr *)&server , len);
    if( sntb == -1)
    {
        close(s);
        std::cout << "Message sending Failed";
        return -1;
    }
    if(!strcmp(buff,"stop"))
    {
        break;
    }
    recb = recvfrm(s,buff,sizeof(buff),0,(struct sockaddr *)&server, &sa);
    if ( recb ==-1)
    {
        std::cout << " \n Message Recieved failed .";
        close(s);
        return -1;
    }
    std::cout<< "Message recieved: " << buff;
    if(!strcmp(buff,"stop"))
    {
        break;
    }
    close(s);
}