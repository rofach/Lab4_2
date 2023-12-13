using System;
using System.Text;

namespace lab
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Write string: ");
			StringBuilder str = new StringBuilder(Console.ReadLine());
			// Спочатку видяляємо символи, що не є літерами та цифрами
			for (int positionNumber = 0; positionNumber < str.Length; positionNumber++)
			{
				if (!(Char.IsDigit(str[positionNumber]) || Char.IsLetter(str[positionNumber])))
				{
					str.Remove(positionNumber, 1);
					positionNumber--;
				}
			}
			//тепер переносимо цифри у кінець у зворотньому порядку
			int length = str.Length;
			for (int positionNumber = 0; positionNumber < length; positionNumber++)
			{
				if (Char.IsDigit(str[positionNumber]))
				{
					str.Insert(length, str[positionNumber]);
					str.Remove(positionNumber, 1);
					length--;
					positionNumber--;
				}
			}
			Console.WriteLine(str);
		}
	}
}