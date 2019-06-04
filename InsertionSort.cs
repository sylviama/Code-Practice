using System;
					
public class Program
{
	public static void Main()
	{
		int[] input= new int[7]{2,5,3,1,6,7,8};
		int[] output=Insertion.InsertionSort(input);
		foreach(int item in output)
		{
			Console.WriteLine(item);
		}
		
	}
}

public class Insertion
{
	public static int[] InsertionSort(int[] input)
	{
		for(int i=1;i<input.Length;i++)
		{
			int j=i;
			while(j>0)
			{
				if(input[j-1]>input[j])
				{
					int temp=input[j];
					input[j]=input[j-1];
					input[j-1]=temp;
				}
				j--;
			}
		}
		
		return input;
	}

}
