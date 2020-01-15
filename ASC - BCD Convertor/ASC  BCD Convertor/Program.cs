using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC__BCD_Convertor
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 0;
			try
			{
				n = int.Parse(Console.ReadLine());
			}
			catch (FormatException)
			{
				Console.WriteLine("Nu ati introdus un număr");
			}
			int index = 0;
			int[] cifren = new int[10];
			string[] digits = new string[10];

			digits[0] = "0000";
			digits[1] = "0001";
			digits[2] = "0010";
			digits[3] = "0011";
			digits[4] = "0100";
			digits[5] = "0101";
			digits[6] = "0110";
			digits[7] = "0111";
			digits[8] = "1000";
			digits[9] = "1001";

			if (n > 0)
			{
				Console.WriteLine("Numărul este pozitiv");

				while (n != 0)
				{
					cifren[index] = n % 10;
					n = n / 10;
					index = index + 1;
				}
				Console.Write("0000 ");

				for (int i = index - 1; i >= 0; i--)
				{
					Console.Write(digits[cifren[i]] + " ");
				}
			}
			else if (n < 0)
			{
				Console.WriteLine("Numărul este negativ");
				n *= -1;
				n -= 1;
				while (n != 0)
				{
					cifren[index] = n % 10;
					n = n / 10;
					index = index + 1;
				}
				Console.Write("1001 ");

				for (int i = index - 1; i >= 0; i--)
				{
					Console.Write(digits[9 - cifren[i]] + " ");
				}
			}
			else if (n == 0)
			{
				Console.Write("0000 ");
			}
			Console.ReadLine();
		}
	}
}
