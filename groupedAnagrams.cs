using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Input list of words
        List<string> words = new List<string> { "cat", "dog", "tac", "God", "act" };
        //output cat, tac, act, dog, God
        Dictionary<string, List<string>> groupedAnagrams = new Dictionary<string, List<string>>();

        foreach (var word in words)
        {
            int[] charCount = new int[26];
            foreach (char c in word.ToLower())
            {
                charCount[c - 'a']++;
            }

            string key = string.Join(",", charCount);
            if (!groupedAnagrams.ContainsKey(key))
            {
                groupedAnagrams[key] = new List<string>();
            }
            groupedAnagrams[key].Add(word);
        }

        foreach (var group in groupedAnagrams.Values)
        {
            Console.WriteLine(string.Join(", ", group));
        }
    }
}
