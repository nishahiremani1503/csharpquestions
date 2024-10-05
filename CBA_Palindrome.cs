// Online C# Editor for free
// // Write, Edit and Run your C# code using C# Online Compiler
// Enter string: 
// madam
// 'madam' is Palindrome
using System;

public class Palindrom
{
    public static void Main()
    {
        Console.WriteLine("Enter string: ");
        string input=Console.ReadLine();
        if(IsPalindrome(input)){
            Console.WriteLine($"'{input}' is Palindrome");
        }else{
        Console.WriteLine ($"'{input}' not palindrome");
        }
    }
    public static bool IsPalindrome(string str){
        string a= str.ToLower().Replace(" ","");
        int left=0;
        int right= a.Length-1;
        while(left<right){
            if(a[left]!=a[right]){
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
