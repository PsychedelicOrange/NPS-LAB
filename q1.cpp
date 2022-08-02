#include <iostream>
#include <string>
#include <unistd>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdlib.h>
#include <stdio.h>
int main()
{
    int s,r,recb,sntb,x;
    int ca;
    std::cout << "INPUT port number :";
    std::cin>>x;
    socklen_t len;
    struct sockaddr_in server,client;
    char buff[50];
    s = socket(AF_INET,SOCK_DIAGRAM,0);
    if(s==-1)
    {
        std::cout<<"\nSocket creation error .";
        return -1;
    }
    std::cout<<"\nSocket created"
    server.sin_family = AF_INET;
    server.sin_port = htons(x);
    server.sin_addr.s_addr = htonl(INADDR_ANY);
    len = sizeof(client);
    ca = sizeof(client);
    r = bind(s.(struct sockaddr*)&server, sizeof(server));
    if(r == -1)
    {
        srd::cout << "\nBinding error .";
        return -1;
    }
    while(1)
    {
        recb = recvfrom(s,buff,sizeof(buff),0,(struct sockaddr*)&client,&ca);
        if(recb==-1)
        {
            std::cout<<"\nMessage Recieving Failed";
            close(s);
            return -1;
        }
        std::cout << "\nMessage Recieved: "<<buff;
        if(!strcmp(buff,"stop"))
        {
            break;
        }
        std::cout << "\n\nType Message: ";
        scanf("%s",buff);
        sntb = sendto(s,buff,sizeof(buff),0,(struct sockaddr*)&client,len);
        if( sntb == -1)
        {
            std::cout << "Message Sesnding Failed";
            close(s);
            return -1;
        }
        if(!strcmp(buff,"stop"))
        {
            break;
        }
        close(s);
    }
    

}