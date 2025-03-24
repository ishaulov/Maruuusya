using System;
using System.Collections.Generic;
using System.Linq;

class MaxNumber {
    static void Main() {
        List<int> testTimes = GetTestCompletionTimes();

        Console.Write("Время выполнения каждого теста (в секундах): ");
        foreach(int time in testTimes){
            Console.Write($"{time} ");
        }

        var maxNumber = 0;
        
        foreach (int time in testTimes)
        {
            if (maxNumber < time)
            {
                maxNumber = time;
            }
        }
        Console.WriteLine($"Big znachenine: {maxNumber}");
        
        
        // используй только переменные, условия, циклы
        
        // 1. Найди и выведи самый продолжительный тест в списке testTimes 
        // в списке только положительные числа
        // доп. задание*: выведи порядковый номер самого продолжительного теста в списке
        
        // 2. Найди и выведи время, которое заняло выполнение всех тестов из списка
        
        // 3. Найди и выведи самый быстрый тест в списке testTimes 
        // самое долгое возможное время выполнения теста - 5 минут
        // доп. задание*: выведи порядковый номер самого быстрого теста в списке
        
    }
  
    static List<int> GetTestCompletionTimes(){
        Random rand = new Random();
        List<int> numbers = new List<int>();
        for(int i=0; i < rand.Next(1, 20); i++)
        {
            numbers.Add(rand.Next(1, 300));
        }
        return numbers;
    }
}