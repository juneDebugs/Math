using System;
using System.Security.Cryptography;
using System.Collections.Concurrent;

namespace Math
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int number1;
			number1 = 5;
			//5
			Console.WriteLine(number1);
			number1 = number1 * 5;
			//25
			Console.WriteLine(number1);
			number1 += 5;
			//30
			Console.WriteLine(number1);
			number1 -= 10;
			//20
			Console.WriteLine(number1);
			number1 *= 2;
			//40
			Console.WriteLine(number1);
			number1 /= 8;
			//5
			Console.WriteLine(number1);
			Console.WriteLine(--number1);
			//4
			Console.WriteLine(number1--);
			Console.WriteLine(number1);
		}		




	}
}
