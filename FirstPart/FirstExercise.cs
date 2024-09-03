using System;

public class TesteDeMesa
{
    public static void FirstTrace()
    {
        int a = 10;
        int b = 20;
        int c = (a + b) / 2;
        c = c - 40;
        Console.Write("Informe o indíce: ");
        int indexNumber = Convert.ToInt32(Console.ReadLine());

        int[] v = new int[indexNumber];

        for (int i = 0; i < indexNumber; i++)
        {
            if (i == 3)
            {
                v[i] = a + b + c;
            }

            Console.Write($"v[{i}] = {v[i]} ");

            if (v[i] == 5)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }


    public static void SecondTrace()
    {
        int a = 2;
        int[] v = new int[7];


        while (a < 6)
        {
            v[a] = 10 * a;
            Console.WriteLine($"{a} ==> {v[a]}");
            a += 1;
        }
    }


    public static void ThirdTrace()
    {
        int a = 7;
        int b = a - 6;
        int[] v = new int[20];
        int indexNumber = 0;

        while (indexNumber < v.Length)
        {
            if (b < v.Length && b < indexNumber)
            {
                v[b] = b + a;
            }

            if (b < v.Length && b < a)  // Verifica se 'b' está dentro do array e da condição
            {
                Console.WriteLine($"Operador: {v[b]} - True");
            }
            else
            {
                Console.WriteLine($"Operador: {v[b]} - False");
            }

            b += 2;
            indexNumber += 1;

            if (b >= v.Length)
            {
                break;
            }
        }
    }

}
