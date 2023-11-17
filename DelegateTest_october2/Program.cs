namespace DelegateTest_october2
{
	internal class Program
	{
		static IEnumerable<int> ShowNumbers()
		{
			for (int i = 0; i < 10; i++)
			{
				yield return i;
			}
		}

		static void Main(string[] args)
		{
			int[] array = { 3, 3, 2, 1, 4, 5, 6 };

			// LINQ - Language INtegrated Query, Functional Programming

			//int result = ShowNumbers().Where(a => (a * x) % 2 == 0).SkipWhile(a => a < 7).Max();

			//var list = ShowNumbers().Where(a => a % 2 == 0).ToList();

			// list = ShowNumbers().ToList().Where(a => a % 2 == 0);

			int x = 10;

			var f = array.Where(a =>
			{
				x++;
				return a % 2 == 0;

			});

			Console.WriteLine(x);


			f.Max();

			Console.WriteLine(x);
		}
	}
}