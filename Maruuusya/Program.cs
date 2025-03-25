using System;
using System.Collections.Generic;
using System.Linq;

class MaxNumber
{
    static int Cube(int c)
    {
        int Cube3 = c * c * c;
        return Cube3;
    }

    static int Stepen(int a, int b)
    {
        int step = 1;

        for (int i = 0; i < b; i++)
        {
            step = a * step;
        }

        return step;
    }

    static void Main()
    {
        int myCube = Cube(5);
        Console.WriteLine(myCube);

        int myStepen = Stepen(3, 3);
        Console.WriteLine(myStepen);
    }
}