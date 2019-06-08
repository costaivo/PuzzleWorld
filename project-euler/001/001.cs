using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            n=n-1;
           
            long sum = SumDivisbleBy(3,n)+SumDivisbleBy(5,n)-SumDivisbleBy(15,n);
            Console.WriteLine(sum);
            
        }
    }

    static long SumDivisbleBy(int n,int  p){
    long sum = n * ((long)(p / n)) * (((long)(p / n)) + 1) / 2;
    return sum;
}
}

