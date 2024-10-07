// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
//Write a program to find the largest and smallest element of a given unsorted array.
using System;

public class LargestSmallestElement
{
    public static void Main()
    {
        int[] arr= {12,3,4,5,6,7,19,-1,-2,20};
        int largest= FindLargest(arr);
        int smallest= FindSmallest(arr);
        int secondlargest= FindSecondLargest(arr);
        if(secondlargest!=int.MinValue){
             Console.WriteLine("Second Largest: "+secondlargest);
        }
        
        Console.WriteLine("Largest: "+largest);
        Console.WriteLine("Smallest: "+smallest);
       
        
    }
    
    static int FindSecondLargest(int[] arr){
        int a=int.MinValue;
        int secondlargest=int.MinValue;
        foreach(int i in arr){
            //int[] arr= {12,3,4,5,6,7,19,-1,-2,20};
            if(i>a){
                secondlargest= a;
                a=i;
            }
            else if(i> secondlargest && i!=a){
                secondlargest=i;
            }
        }
        return secondlargest;
    }
    
    static int FindLargest(int[] arr){
        int max= arr[0];
        for(int i=1;i<arr.Length;i++){
            if(arr[i]>max){
                max=arr[i];
            }
        }
        return max;
    }
    static int FindSmallest(int[] arr){
        int min=arr[0];
        for(int i=1;i<arr.Length;i++){
            if(arr[i]<min){
                min=arr[i];
            }
        }
         return min;
    }
    
}
