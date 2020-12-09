using System;

namespace PalProgramming {
	class Program {
		static void Main(string[] args) {
			//Console.WriteLine("Hello World!");

			//string my_string = "Hellow World!";
			//Console.WriteLine(my_string);
			//Console.ReadLine();

			//NintyNineBottles();

			//if (args.Length > 0) {
			//	Console.WriteLine(args[0]);
			//	Console.ReadLine();
			//}
			//try {
			//	int error_zero = 0;
			//	int error = 100 * error_zero;
			//} catch ( Exception ex) {
			//	Console.WriteLine(ex.Message);
			//	Console.ReadLine();
			//
			Console.WriteLine("Enter Your Name");
			string user_name = Console.ReadLine();
			Console.ReadLine();

			string my_string_c = $"hello there, PAL student ({user_name})";
			Console.WriteLine(my_string_c);
			Console.ReadLine();
			string first_sentance = "this is the first part";
			string second_sentance = "this is the second part";
			Console.WriteLine($"{first_sentance} + {second_sentance}");
			Console.ReadLine();

			bool has_space = user_name.IndexOf(" ") > -1;
			string[] reversed_name = user_name.Split(" ");
			Console.WriteLine(has_space ? $"reversed_name[1]), {reversed_name[0]}" : user_name);
			Console.ReadLine();

			string period_name = user_name.Replace(" ", ".");
			Console.WriteLine(period_name);
			Console.ReadLine();
		}
		static void NintyNineBottles() {
			for (int i = 99; i >= 0; i--) {

				if (i == 50) {
					Console.WriteLine($"{i} bottles of beer on the wall, almost halfway!");
				} else {
					Console.WriteLine($"{i} bottles of beer on the wall");
				}
			}
			Console.ReadLine();
		}
	}
}