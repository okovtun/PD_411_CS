﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	class Program
	{
		static void Main(string[] args)
		{
			ConsoleKey key;
			do
			{
				key = Console.ReadKey(true).Key;
				Console.WriteLine(key);
			} while (key != ConsoleKey.Escape);
		}
	}
}
