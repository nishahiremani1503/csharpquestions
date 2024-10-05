// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
//MergeSortedArray

using System;

public class MergeArray
{
    public static void Main()
    {
        int[] a1={1,3,5,7,9};
        int[] a2= {0,2,4,6,8};
        int[] b=MergeSortedArray(a1,a2);
        Console.WriteLine(string.Join(", ", b));
    }
    static int[] MergeSortedArray(int[] arr1,int[] arr2){
        int[] result= new int[arr1.Length+arr2.Length];
        int i=0, j=0,k=0;
        while(i<arr1.Length && j<arr2.Length){
            if(arr1[i]<arr2[j]){
                result[k++]=arr1[i++];
            }else{
                result[k++]=arr2[j++];
            }
        }
        while(i<arr1.Length){
            result[k++]=arr1[i++];
        }
        while(j<arr2.Length){
            result[k++]=arr2[j++];
        }
        return result;
    }
}
