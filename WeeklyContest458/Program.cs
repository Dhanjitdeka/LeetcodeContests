using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//https://leetcode.com/problems/process-string-with-special-operations-i/
public class Solution 
{
    // Problem 1: Replace with actual problem
    public String processStr(String s)  
    {
        // In C#, StringBuilder is used when you need to manipulate strings repeatedly or perform many string concatenations. 
        // This is because strings in C# are immutable, meaning every time you modify a string, 
        // you're actually creating a brand new one in memory. 
        StringBuilder result = new StringBuilder();

        foreach (char c in s.ToCharArray())
        {
            if (c <= 'z' && c >= 'a')
            {
                result.Append(c);
            }
            else if (c == '*')
            {
                if (result.Length > 0)
                {
                    result.Remove(result.Length - 1, 1);
                }
            }
            else if (c == '#')
            {
                // no need to use result.toString() inside the append method
                result.Append(result);
            }
            else if (c == '%')
            {
                char[] charArray = result.ToString().ToCharArray();
                Array.Reverse(charArray);
                // made a rookie mistake by doing charArray.toString()
                // it does not return a string version of the array as I thought.
                // By default, Object.ToString() returns the type name (unless overridden)
                // StringBuilder overrides ToString() to return the actual string it's building
                result = new StringBuilder(new string(charArray));
                
            }
        }
        
        return result.ToString();
    }
    
    // Problem 2: Replace with actual problem
    public string Problem2() 
    {
        // Implementation here
        return "";
    }
    
    // Problem 3: Replace with actual problem
    public bool Problem3() 
    {
        // Implementation here
        return false;
    }
    
    // Problem 4: Replace with actual problem
    public int Problem4() 
    {
        // Implementation here
        return 0;
    }
}

// Helper class for testing
public class Program 
{
    public static void Main(string[] args) 
    {
        Solution solution = new Solution();
        
        // Test Problem 1
        
        Console.WriteLine($"Problem 1 Result: {solution.processStr("a#b%*")}");
        
        // Test Problem 2
        
        Console.WriteLine($"Problem 2 Result: {solution.Problem2()}");
        
        // Test Problem 3
        Console.WriteLine($"Problem 3 Result: {solution.Problem3()}");
        
        // Test Problem 4
       
        Console.WriteLine($"Problem 4 Result: {solution.Problem4()}");
    }
}
