#include <iostream>
int main()
{
    int arr[10]={12,2,45,6,0,32,42,2,66,7};
    int smallest,j =0;
    for(int j=0;j<10;j++)
    {
        for(int i=j+1;i<10;i++)
        {
            if(arr[i]<arr[smallest])
                smallest = i;
        }
        int temp = arr[j];
        arr[j] = arr[smallest];
        arr[smallest] = temp;
    }
    for(int j=0;j<10;j++)
        cout << arr[j] << " ";
    return 0;
}