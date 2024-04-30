using System;
using System.Collections.Generic;
using System.Linq;

int [] vetor= {
    1,2,3,4,5,6,7,8,9,0,12,23,12,3,4
};

var buscarPare = from c in vetor
                where c==2
                select c;

foreach(var c in buscarPare){
    Console.WriteLine($"No vetor {c} se encotra na posição{c}");
}