using System;
using System.Collections.Generic;
using System.Linq;

int [] vetor= 
{
    1,2,3,4,5,6,7,8,9,12,23,12,3,4
};
int maior=vetor[0];
int menor=vetor[0];
 for (int i =0; i<vetor.Length;i++)
{
        if (vetor[i]>maior)
        {
            maior=vetor[i];
        }
        else if (vetor[i]<menor)
        {
            menor=vetor[i];
        }
}

Console.WriteLine(maior) ; 
Console.WriteLine(menor) ; 


