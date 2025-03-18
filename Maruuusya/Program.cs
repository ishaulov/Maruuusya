namespace Maruuusya;

class Program
{
	static void Main(string[] args)
	{
		string nginxConfigPath = @"/etc/nginx/nginx.conf";
		Console.WriteLine(nginxConfigPath);

		bool happy = true;
		Console.WriteLine(happy);
		
		object height = 1.60; 
		object name = "Christopher Robin"; 
		Console.WriteLine($"{name} is {height} metres tall!");
		// int length1 = name.Length;
		int length2 = ((string)name).Length; 
		Console.WriteLine($"{name} has {length2} characters!");
		
		dynamic something = "Good";
		Console.WriteLine($"Good length is {something.Length}");
		
		List<Test> testsToRun = GetTests();

		for (int i = 0; i < testsToRun.Count; i++)
		{
			var msg = testsToRun[i].Run();
			if (msg)
			{
				//Console.WriteLine($"Номер теста: {i}, успешен!");
			}
			else
			{
				//Console.WriteLine($"Номер теста: {i}, провален!");
			}
		}

		static List<Test> GetTests()
		{
			var testsCode = "1 1 1 0 0 0 1 0 1 0 1".Split(' ');
			var tests = new List<Test>();

			foreach (var testCode in testsCode)
			{
				var test = new Test();
				test.TestCode = testCode;
				tests.Add(test);
			}

			return tests;
		}
	}

	class Test
	{
		public string TestCode = string.Empty;

		public bool Run()
		{
			return TestCode == "1" ? true : false;
		}
	}
}