namespace Task1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 2 array verilmişdir, 2ci arraydəki bütün elementlər həm də 1cidə varsa , true əks halda false çap olunsun.
			int[] arr1 = { 23, 45, 32, 46, 57, 89, 54, 34, 58, 87, 65 };
			int[] arr2 = { 23, 54, 34, 58, 87, 65 };

			bool result = false;


			for (int i = 0; i < arr1.Length; i++)
			{
				for (int j = 0; j < arr2.Length; j++)
				{
					if (arr1[i] == arr2[j])
					{
						result = true;
					}
					else
					{
						result = false;
					}

				}
			}
			Console.WriteLine(result);
		}
	}
}