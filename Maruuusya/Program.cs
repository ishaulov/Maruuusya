﻿namespace Maruuusya;

class Program
{
    static void Main(string[] args)
    {
        List<Test> testsToRun = GetTests();

        for (int i = 0; i < testsToRun.Count; i++)
        {
            var msg = testsToRun[i].Run();
            if (msg)
            {
                Console.WriteLine($"Номер теста: {i}, успешен!");
            }
            else
            {
                Console.WriteLine($"Номер теста: {i}, провален!");
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