class AddTwoNumbers
{
	static void Main()
	{
		string firstNum = Console.ReadLine();
		char[] str1 = firstNum.ToCharArray();
		int[] num1 = Array.ConvertAll(str1, a => (int)Char.GetNumericValue(a));  
		int len1 = num1.Length;
		string secondNum = Console.ReadLine();
		char[] str2 = secondNum.ToCharArray();
		int[] num2 = Array.ConvertAll(str2, b => (int)Char.GetNumericValue(b));
		int len2 = num2.Length;
		int minLen;
		int maxLen;

		if (len1 < len2)
		{
			minLen = len1;
			maxLen = len2;
			Array.Reverse(num1);
			Array.Reverse(num2);
			Array.Resize(ref num1, maxLen);
			for (int m = minLen; m < maxLen; m++)
			{
				num1[m] = 0;
			}
		} 
		else if (len2 < len1)
		{
			minLen = len2;
			maxLen = len1;
			Array.Reverse(num1);
			Array.Reverse(num2);
			Array.Resize(ref num2, maxLen);
			for (int m = minLen; m < maxLen; m++)
			{
				num2[m] = 0;
			}
		}
		else
		{
			minLen = len1;
			maxLen = len2;
			Array.Reverse(num1);
			Array.Reverse(num2);
		}

		int[] sum = new int[maxLen + 1];

		for (int m = 0; m < maxLen; m++)
		{
			sum[m] = num1[m] + num2[m];
			if (sum[m] >= 10)
			{
				sum[m] = sum[m] - 10;
				if (m + 1 == maxLen)
				{
					sum[m + 1] = 1;
				}
				else
				{
					num1[m + 1]++;
				}
			}
			else
			{
				sum[m] = num1[m] + num2[m];
			}
		}
		Array.Reverse(sum);
		foreach (var item in sum)
		{
			Console.Write(item.ToString());
		}
	}
}
