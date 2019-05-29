using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		String input = "tutorial horizon";
        FindDuplicate.findDuplicates(input);
	}
}

public class FindDuplicate
{
	public static void findDuplicates(string input)
	{
		IDictionary<char, int> dict = new Dictionary<char, int>();
		char[] inputChar = input.ToCharArray();
		
		foreach(char letter in inputChar)
		{
			if(dict.ContainsKey(letter))
			{
				dict[letter] +=1;
			}else
			{
				dict.Add(letter,1);
			}
		}
		
		foreach(KeyValuePair<char, int> item in dict)
		{
			if(item.Value>1)
			{
				Console.WriteLine("{0} is {1}", item.Key, item.Value);
			}
		}
	}
}

