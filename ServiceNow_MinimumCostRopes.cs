// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
// 5,3,4,8,6 , cost= 8     3,4 cost=7   5,7,8,6
//8, 4, 8, 6 cost=12+8    5,6 cost= 11 11,7,8
//12,8,6 cost=12+8+20     7, 8 cost = 15  11,15
//20,6 cost=              11,15 cost = 26    59
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> ropes = new List<int>{5,3,4,8,6};
        
        int mincost= MinimumCost(ropes);
        Console.WriteLine("mincost "+ mincost);
    }
    
    static int MinimumCost(List<int> ropes){
        var minHeap= new SortedSet<(int value, int key)>();
        int key=0;
        foreach(var rope in ropes){
            minHeap.Add((rope, key++));
        }
        int totalCost=0;
        while(minHeap.Count>1){
            var first= minHeap.Min;
            minHeap.Remove(first);
            var second = minHeap.Min;
            minHeap.Remove(second);
            
            int combineRopes= first.value+ second.value;
            totalCost+= combineRopes;
            minHeap.Add((combineRopes, key++));
        }
        return totalCost;
    }
}
